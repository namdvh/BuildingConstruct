using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using ViewModels.BillModels;
using System.Linq.Dynamic.Core;
using ViewModels.Carts;
using ViewModels.Pagination;
using ViewModels.Response;
using System.Text;

namespace Application.System.Bill
{
    public class BillServices : IBillServices
    {
        private readonly BuildingConstructDbContext _context;
        private IHttpContextAccessor _accessor;
        public BillServices(BuildingConstructDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        public async Task<bool> CreateBill(List<BillDTO> requests)
        {
            bool flag = false;
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            var usID = identifierClaim.Value;
            var contracID = _context.Users.Where(x => x.Id.ToString().Equals(usID)).FirstOrDefault().ContractorId;
            foreach (var r in requests)
            {
                var bill = new Data.Entities.Bill();
                bill.Note = r.Notes;
                bill.Status = r.Status;
                bill.StartDate = DateTime.Now;
                bill.EndDate = r.EndDate;
                bill.TotalPrice = r.TotalPrice;
                bill.ContractorId = contracID;
                bill.StoreID = r.StoreID;
                bill.CreateBy = Guid.Parse(usID);
                bill.LastModifiedAt = DateTime.Now;
                await _context.AddAsync(bill);
                var rs = await _context.SaveChangesAsync();
                if (rs > 0)
                {

                    foreach (var item in r.ProductBillDetail)
                    {
                        var billDetail = new BillDetail();
                        billDetail.BillID = bill.Id;
                        billDetail.ProductID = item.ProductId;
                        billDetail.ProductTypeId = r.ProductTypeId;
                        billDetail.Quantity = item.Quantity;
                        billDetail.Price = item.Price;

                        _context.BillDetails.Add(billDetail);
                        _context.SaveChanges();
                    }
                }
                flag = true;
            }

            IQueryable<Cart> query = _context.Carts.Where(x => x.UserID.ToString().Equals(usID.ToString()));
            StringBuilder existed = new();
            var count = requests.Count;

            List<Cart> ls = new();
            if (flag == true)
            {
                foreach (var item in requests)
                {
                    foreach (var pro in item.ProductBillDetail)
                    {
                        var product = _context.Carts.Where(x => x.ProductID == pro.ProductId && x.UserID.ToString().Equals(usID.ToString()) && x.TypeID==pro.TypeID).FirstOrDefault();
                        ls.Add(product);
                    }
                }
                _context.RemoveRange(ls);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<BasePagination<List<BillDTO>>> GetAllBill(PaginationFilter filter)
        {
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            var usID = identifierClaim.Value;
            var storeID = _context.Users.Where(x => x.Id.ToString().Equals(usID)).FirstOrDefault().MaterialStoreID;
            var contracID = _context.Users.Where(x => x.Id.ToString().Equals(usID)).FirstOrDefault().ContractorId;
            BasePagination<List<BillDTO>> response;
            var orderBy = filter._orderBy.ToString();
            int totalRecord;

            if (string.IsNullOrEmpty(filter._sortBy))
            {
                filter._sortBy = "Id";
            }
            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };

            IQueryable<Data.Entities.Bill> query = _context.Bills;
            var data = await query

             .OrderBy(filter._sortBy + " " + orderBy)
             .Skip((filter.PageNumber - 1) * filter.PageSize)
             .Take(filter.PageSize)
             .ToListAsync();
            if (storeID != null)
            {
                data = data.Where(x => x.StoreID == storeID).ToList();
            }
            if (contracID != null)
            {
                data = data.Where(x => x.ContractorId == contracID).ToList();

            }

            var totalRecords = await _context.Bills.CountAsync();

            if (!data.Any())
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.EMPTY_MESSAGE,
                    Data = new List<BillDTO>(),
                };
            }
            else
            {
                double totalPages;

                totalPages = totalRecords / (double)filter.PageSize;

                var roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
                Pagination pagination = new()
                {
                    CurrentPage = filter.PageNumber,
                    PageSize = filter.PageSize,
                    TotalPages = roundedTotalPages,
                    TotalRecords = totalRecords
                };

                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = await MapListDTO(data),
                    Pagination = pagination
                };
            }

            return response;
        }

        private async Task<List<BillDTO>> MapListDTO(List<Data.Entities.Bill> data)
        {
            List<BillDTO> rs = new();
            foreach (var item in data)
            {
                var store = await _context.Users.FirstOrDefaultAsync(x => x.MaterialStoreID == item.StoreID);



                BillDTO bill = new();
                bill.BillId = item.Id;
                bill.TotalPrice = item.TotalPrice;
                bill.StoreID = item.StoreID;
                bill.StoreName = store.FirstName + " " + store.LastName;
                bill.Notes = item.Note;
                bill.StartDate = (DateTime)item.StartDate;
                bill.EndDate = item.EndDate;
                bill.Status = item.Status;
                rs.Add(bill);
            }
            return rs;
        }

        public async Task<BaseResponse<BillDetailDTO>> GetDetail(int billID)
        {
            BaseResponse<BillDetailDTO> response;

            var rs = await _context.BillDetails
                .Include(x => x.Bills)
                    .ThenInclude(x => x.MaterialStore)
                    .ThenInclude(x => x.User)
                .Include(x => x.Bills)
                    .ThenInclude(x => x.Contractor)
                .Include(x => x.Products)
                .Where(x => x.BillID == billID)
                .ToListAsync();
            if (!rs.Any())
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Data = new(),
                    Message = BaseCode.NOTFOUND_MESSAGE
                };
                return response;
            }


            response = new()
            {
                Code = BaseCode.SUCCESS,
                Message = BaseCode.SUCCESS_MESSAGE,
                Data = MapDetailDTO(rs),
            };

            return response;

        }

        public async Task<BaseResponse<SmallBillDetailDTO>> GetDetailBySmallBill(int billID)
        {
            BaseResponse<SmallBillDetailDTO> response;

            var result = await _context.Bills
                .Include(x => x.MaterialStore)
                    .ThenInclude(x => x.User)
                .Where(x => x.Id == billID).FirstOrDefaultAsync();

            if (result != null)
            {

                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = MapSmallDetailDTOFirstType(result),
                };
            }
            else
            {
                response = new()
                {
                    Code = BaseCode.ERROR,
                    Message = BaseCode.ERROR_MESSAGE,
                };
            }
            return response;

        }

        public BillDetailDTO MapDetailDTO(List<BillDetail> list)
        {
            List<ProductBillDetail> product = new();

            foreach (var item in list)
            {
                ProductBillDetail pro = new()
                {
                    Image = item.Products.Image,
                    ProductBrand = item.Products.Brand,
                    ProductDescription = item.Products.Description,
                    ProductName = item.Products.Name,
                    UnitPrice = item.Products.UnitPrice,
                    BillDetailQuantity = item.Quantity,
                    BillDetailTotalPrice = item.Price
                };
                product.Add(pro);
            }


            BigBillDetail bill = new()
            {
                ContractorId = list.First().Bills.ContractorId.Value,
                EndDate = list.First().Bills.EndDate,
                Id = list.First().Bills.Id,
                Note = list.First().Bills.Note,
                PaymentDate = list.First().Bills.PaymentDate,
                StartDate = list.First().Bills.StartDate,
                Status = list.First().Bills.Status,
                StoreID = list.First().Bills.StoreID,
                //StoreName = list.First().Bills.MaterialStore.User.FirstName + " " + list.First().Bills.MaterialStore.User.LastName,
                TotalPrice = list.First().Bills.TotalPrice,
                Type = list.First().Bills.Type

            };


            BillDetailDTO dto = new()
            {
                Bill = bill,
                Products = product,
            };
            return dto;
        }



        private SmallBillDetailDTO MapSmallDetailDTOFirstType(Data.Entities.Bill bill)
        {
            List<SmallBillDTO> smallDetails = new();

            BigBillDetail BillDTO = new()
            {
                ContractorId = bill.ContractorId.Value,
                EndDate = bill.EndDate,
                Id = bill.Id,
                Note = bill.Note,
                PaymentDate = bill.PaymentDate,
                StartDate = bill.StartDate,
                Status = bill.Status,
                StoreID = bill.StoreID,
                TotalPrice = bill.TotalPrice,
                Type = bill.Type

            };


            StoreDTO store = new()
            {
                Avatar = bill.MaterialStore.User.Avatar,
                Email = bill.MaterialStore.User.Email,
                Id = bill.StoreID,
                StoreName = bill.MaterialStore.User.FirstName + " " + bill.MaterialStore.User.LastName,
            };

            SmallBillDTO small = new()
            {

                ProductBillDetail = MapProductDTO(bill.Id)
            };
            smallDetails.Add(small);



            SmallBillDetailDTO dto = new()
            {
                Bill = BillDTO,
                Details = smallDetails,
                Store = store
            };
            return dto;
        }

        private List<ProductBillDetail> MapProductDTO(int id)
        {
            List<ProductBillDetail> list = new();

            var rs = _context.BillDetails
                .Include(x => x.Products)
                .Include(x => x.ProductTypes)
                .Where(x => x.BillID == id)
                .ToList();

            foreach (var item in rs)
            {
                ProductBillDetail pro = new()
                {
                    Image = item.Products.Image,
                    ProductBrand = item.Products.Brand,
                    ProductDescription = item.Products.Description,
                    ProductName = item.Products.Name,
                    UnitPrice = item.Products.UnitPrice,
                    BillDetailQuantity = item.Quantity,
                    BillDetailTotalPrice = item.Price,
                };
                list.Add(pro);
            }
            return list;
        }
    }


}
