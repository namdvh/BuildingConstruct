using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
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

        public async Task<bool> CreateBill(BillDTO requests)
        {
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            var usID = identifierClaim.Value;
            var storeID = _context.Users.Where(x => x.Id.ToString().Equals(usID)).FirstOrDefault().MaterialStoreID;
            var contracID = _context.Users.Where(x => x.Id.ToString().Equals(usID)).FirstOrDefault().ContractorId;
            var bill = new Data.Entities.Bill();
            bill.Note = requests.Notes;
            bill.Status = requests.Status;
            bill.StartDate = DateTime.Now;
            bill.EndDate = DateTime.Now.AddMonths((int)requests.MonthOfInstallment);
            bill.TotalPrice = requests.TotalPrice;
            bill.Type = requests.BillType;
            bill.MonthOfInstallment = requests.MonthOfInstallment;
            bill.ContractorId = contracID;
            bill.StoreID = storeID;
            bill.CreateBy = Guid.Parse(usID);
            bill.LastModifiedAt = DateTime.Now;
            await _context.AddAsync(bill);
            var rs = await _context.SaveChangesAsync();
            if (rs > 0)
            {

                foreach (var item in requests.ProductBillDetail)
                {
                    var billDetail = new BillDetail();
                    billDetail.BillID = bill.Id;
                    billDetail.ProductID = item.ProductId;
                    billDetail.Quantity = item.Quantity;
                    billDetail.Price = item.Price;

                    _context.BillDetails.Add(billDetail);
                    _context.SaveChanges();
                }
                if (requests.SmallBill != null && requests.BillType == Data.Enum.BillType.Type2)
                {
                    //foreach (var item in requests.SmallBill)
                    //{
                    for (int i = 0; i < requests.SmallBill.Count; i++)
                    {
                        var smallBill = new Data.Entities.SmallBill();
                        smallBill.Note = requests.SmallBill[i].Notes;
                        smallBill.Status = requests.SmallBill[i].Status;
                        if (i == 0)
                        {
                            smallBill.StartDate = DateTime.Now;
                            smallBill.EndDate = DateTime.Now.AddMonths(1);
                            requests.SmallBill[i].EndDate = DateTime.Now.AddMonths(1);
                        }
                        else
                        {
                            smallBill.StartDate = requests.SmallBill[i - 1].EndDate;
                            smallBill.EndDate = DateTime.Parse(requests.SmallBill[i - 1].EndDate.ToString()).AddMonths(1);
                            requests.SmallBill[i].EndDate = DateTime.Parse(requests.SmallBill[i - 1].EndDate.ToString()).AddMonths(1);

                        }
                        smallBill.TotalPrice = requests.SmallBill[i].TotalPrice;
                        smallBill.BillID = bill.Id;
                        _context.SmallBills.Add(smallBill);
                        var result = _context.SaveChanges();
                        if (result > 0)
                        {
                            if (requests.SmallBill[i].SmallProductDetail != null)
                            {
                                foreach (var item in requests.SmallBill[i].SmallProductDetail)
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
                if (requests.BillType == Data.Enum.BillType.Type3)
                {

                    foreach (var (item,i) in requests.SmallBill.Select((value,i)=>(value,i)))
                    {
                        var smallBill = new Data.Entities.SmallBill();
                        smallBill.Note = item.Notes;
                        smallBill.Status = item.Status;
                        if (i==0)
                        {
                            smallBill.StartDate = DateTime.Now;
                            smallBill.EndDate = DateTime.Now.AddMonths(1);
                            requests.SmallBill[i].EndDate = DateTime.Now.AddMonths(1);
                        }
                        else
                        {
                            smallBill.StartDate = requests.SmallBill[i-1].EndDate;
                            smallBill.EndDate = DateTime.Parse(requests.SmallBill[i - 1].EndDate.ToString()).AddMonths(1);
                            requests.SmallBill[i].EndDate = DateTime.Parse(requests.SmallBill[i-1].EndDate.ToString()).AddMonths(1);
                        }
                        smallBill.TotalPrice = item.TotalPrice;
                        smallBill.BillID = bill.Id;
                        _context.SmallBills.Add(smallBill);
                        var result = _context.SaveChanges();
                    }
                }
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

        public async Task<BaseResponse<List<BillDetailDTO>>> GetDetail(int billID)
        {
            BaseResponse<List<BillDetailDTO>> response;

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
                Data = MapListDetailDTO(rs),
            };

            return response;

        }

        public List<BillDetailDTO> MapListDetailDTO(List<BillDetail> list)
        {
            List<BillDetailDTO> rs = new();

            foreach (var item in list)
            {
                BillDetailDTO dto = new()
                {
                    ContractorID = item.Bills.ContractorId,
                    EndDate = item.Bills.EndDate,
                    Id = item.Id,
                    Image = item.Products.Image,
                    Note = item.Bills.Note,
                    ProductBrand = item.Products.Brand,
                    ProductDescription = item.Products.Description,
                    ProductName = item.Products.Name,
                    StartDate = item.Bills.StartDate,
                    StoreID = item.Bills.StoreID,
                    StoreName = item.Bills.MaterialStore.User.FirstName + " " + item.Bills.MaterialStore.User.LastName,
                    TotalPrice = item.Bills.TotalPrice,
                    UnitPrice = item.Products.UnitPrice
                };
                rs.Add(dto);
            }
            return rs;
        }
    }
}
