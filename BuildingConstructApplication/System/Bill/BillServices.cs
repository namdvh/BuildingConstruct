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
            foreach (var r in requests)
            {
                Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
                var usID = identifierClaim.Value;
                var contracID = _context.Users.Where(x => x.Id.ToString().Equals(usID)).FirstOrDefault().ContractorId;
                var bill = new Data.Entities.Bill();
                bill.Note = r.Notes;
                bill.Status = r.Status;
                bill.StartDate = DateTime.Now;
                bill.EndDate = DateTime.Now.AddMonths((int)r.MonthOfInstallment);
                bill.TotalPrice = r.TotalPrice;
                bill.Type = r.BillType;
                bill.MonthOfInstallment = r.MonthOfInstallment;
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
                        billDetail.Quantity = item.Quantity;
                        billDetail.Price = item.Price;

                        _context.BillDetails.Add(billDetail);
                        _context.SaveChanges();
                    }
                    if (r.SmallBill != null && r.BillType == Data.Enum.BillType.Type2)
                    {
                        for (int i = 0; i < r.SmallBill.Count; i++)
                        {
                            var smallBill = new Data.Entities.SmallBill();
                            smallBill.Status = r.SmallBill[i].Status;
                            if (i == 0)
                            {
                                smallBill.StartDate = DateTime.Now;
                                smallBill.EndDate = DateTime.Now.AddMonths(1);
                                r.SmallBill[i].EndDate = DateTime.Now.AddMonths(1);
                            }
                            else
                            {
                                smallBill.StartDate = r.SmallBill[i - 1].EndDate;
                                smallBill.EndDate = DateTime.Parse(r.SmallBill[i - 1].EndDate.ToString()).AddMonths(1);
                                r.SmallBill[i].EndDate = DateTime.Parse(r.SmallBill[i - 1].EndDate.ToString()).AddMonths(1);

                            }
                            smallBill.TotalPrice = r.SmallBill[i].TotalPrice;
                            smallBill.BillID = bill.Id;
                            _context.SmallBills.Add(smallBill);
                            var result = _context.SaveChanges();
                            if (result > 0)
                            {
                                if (r.SmallBill[i].SmallProductDetail != null)
                                {
                                    foreach (var item in r.SmallBill[i].SmallProductDetail)
                                    {
                                        var smallBillDetail = new BillDetail();
                                        smallBillDetail.SmallBillID = smallBill.Id;
                                        smallBillDetail.ProductID = item.ProductId;


                                        smallBillDetail.Quantity = item.Quantity;
                                        smallBillDetail.Price = item.Price;
                                        _context.BillDetails.Add(smallBillDetail);
                                        _context.SaveChanges();
                                    }
                                }
                            }
                        }

                    }
                    if (r.BillType == Data.Enum.BillType.Type3)
                    {

                        foreach (var (item, i) in r.SmallBill.Select((value, i) => (value, i)))
                        {
                            var smallBill = new Data.Entities.SmallBill();
                            smallBill.Status = item.Status;
                            if (i == 0)
                            {
                                smallBill.StartDate = DateTime.Now;
                                smallBill.EndDate = DateTime.Now.AddMonths(1);
                                r.SmallBill[i].EndDate = DateTime.Now.AddMonths(1);
                            }
                            else
                            {
                                smallBill.StartDate = r.SmallBill[i - 1].EndDate;
                                smallBill.EndDate = DateTime.Parse(r.SmallBill[i - 1].EndDate.ToString()).AddMonths(1);
                                r.SmallBill[i].EndDate = DateTime.Parse(r.SmallBill[i - 1].EndDate.ToString()).AddMonths(1);
                            }
                            smallBill.TotalPrice = item.TotalPrice;
                            smallBill.BillID = bill.Id;
                            _context.SmallBills.Add(smallBill);
                            var result = _context.SaveChanges();
                        }
                    }
                }
                flag = true;
            }
            if (flag == true)
            {
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
                BillDTO bill = new();
                bill.Notes = item.Note;
                bill.StartDate = (DateTime)item.StartDate;
                bill.EndDate = item.EndDate;
                bill.Status = item.Status;
                bill.BillType = item.Type;
                bill.MonthOfInstallment = item.MonthOfInstallment;
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
            var check = await _context.Bills
                .Include(x => x.MaterialStore)
                    .ThenInclude(x => x.User)
                .Where(x => x.Id == billID).FirstOrDefaultAsync();

            if (check.Type == BillType.Type1)
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = MapSmallDetailDTOFirstType(check),
                };
                return response;
            }

            var rs = await _context.SmallBills
                .Include(x => x.Bill)
                    .ThenInclude(x => x.MaterialStore)
                    .ThenInclude(x => x.User)
                .Include(x => x.Bill)
                    .ThenInclude(x => x.Contractor)
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

            if (check.Type == BillType.Type3)
            {

                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = MapSmallDetailDTO(rs, 3),
                };
            }
            else
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = MapSmallDetailDTO(rs, 2),
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
                MonthOfInstallment = list.First().Bills.MonthOfInstallment,
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

        private SmallBillDetailDTO MapSmallDetailDTO(List<Data.Entities.SmallBill> list, int type)
        {
            List<SmallBillDTO> smallDetails = new();

            BigBillDetail bill = new()
            {
                ContractorId = list.First().Bill.ContractorId.Value,
                EndDate = list.First().Bill.EndDate,
                Id = list.First().Bill.Id,
                MonthOfInstallment = list.First().Bill.MonthOfInstallment,
                Note = list.First().Bill.Note,
                PaymentDate = list.First().Bill.PaymentDate,
                StartDate = list.First().Bill.StartDate,
                Status = list.First().Bill.Status,
                StoreID = list.First().Bill.StoreID,
                TotalPrice = list.First().Bill.TotalPrice,
                Type = list.First().Bill.Type

            };


            StoreDTO store = new()
            {
                Avatar = list.First().Bill.MaterialStore.User.Avatar,
                Email = list.First().Bill.MaterialStore.User.Email,
                Id = list.First().Bill.StoreID,
                StoreName = list.First().Bill.MaterialStore.User.FirstName + " " + list.First().Bill.MaterialStore.User.LastName,
            };

            if (type == 2)
            {

                foreach (var item in list)
                {

                    SmallBillDTO small = new()
                    {
                        EndDate = item.EndDate,
                        Id = item.Id,
                        PaymentDate = item.PaymentDate,
                        StartDate = item.StartDate,
                        Status = item.Status,
                        TotalPrice = item.TotalPrice,
                        ProductBillDetail = MapProductDTO(item.Id, false)
                    };
                    smallDetails.Add(small);
                }
            }

            if (type == 3)
            {
                foreach (var item in list)
                {

                    SmallBillDTO small = new()
                    {
                        EndDate = item.EndDate,
                        Id = item.Id,
                        PaymentDate = item.PaymentDate,
                        StartDate = item.StartDate,
                        Status = item.Status,
                        TotalPrice = item.TotalPrice,
                        ProductBillDetail = MapProductDTO(item.Id, true)
                    };
                    smallDetails.Add(small);
                }
            }




            SmallBillDetailDTO dto = new()
            {
                Bill = bill,
                Details = smallDetails,
                Store = store
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
                MonthOfInstallment = bill.MonthOfInstallment,
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

                ProductBillDetail = MapProductDTO(bill.Id, true)
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






        private List<ProductBillDetail> MapProductDTO(int id, bool status)
        {
            List<ProductBillDetail> list = new();


            if (status == true)
            {
                var rs = _context.BillDetails
                    .Include(x => x.Products)
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
                        BillDetailTotalPrice = item.Price
                    };
                    list.Add(pro);
                }
            }
            else
            {

                var rs = _context.BillDetails
                    .Include(x => x.Products)
                    .Where(x => x.SmallBillID == id)
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
                        BillDetailTotalPrice = item.Price
                    };
                    list.Add(pro);
                }
            }



            return list;
        }
    }


}
