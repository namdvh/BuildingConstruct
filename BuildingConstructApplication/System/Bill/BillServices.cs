using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using ViewModels.BillModels;
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
            var bill = new Data.Entities.Bill()
            {
                Note = requests.Notes,
                Status = requests.Status,
                StartDate = requests.StartDate,
                EndDate = requests.EndDate,
                TotalPrice = requests.TotalPrice,
                Type = requests.BillType,
                ContractorId = (int)(contracID == null ? null : contracID),
                StoreID = (int)(storeID == null ? null : storeID),
            };
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
                    foreach (var item in requests.SmallBill)
                    {
                        var smallBill = new Data.Entities.SmallBill();
                        smallBill.Note = item.Notes;
                        smallBill.Status = item.Status;
                        smallBill.StartDate = item.StartDate;
                        smallBill.EndDate = item.EndDate;
                        smallBill.TotalPrice = item.TotalPrice;
                        smallBill.BillID = bill.Id;
                        _context.SmallBills.Add(smallBill);
                        var result = _context.SaveChanges();
                        if (result > 0)
                        {
                        }
                    }

                }
                if (requests.BillType == Data.Enum.BillType.Type3)
                {
                    foreach (var item in requests.SmallBill)
                    {
                        var smallBill = new Data.Entities.SmallBill();
                        smallBill.Note = item.Notes;
                        smallBill.Status = item.Status;
                        smallBill.StartDate = item.StartDate;
                        smallBill.EndDate = item.EndDate;
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

        public async Task<BaseResponse<List<SmallBillDetailDTO>>> GetSmallBillDetail(int smallBillID)
        {
            BaseResponse<List<SmallBillDetailDTO>> response;

            var rs = await _context.SmallBillDetails
                .Include(x => x.SmallBill)
                    .ThenInclude(x => x.Bill)
                        .ThenInclude(x=>x.Contractor)
                            .ThenInclude(x => x.User)
                .Include(x => x.SmallBill)
                    .ThenInclude(x => x.Bill)
                        .ThenInclude(x => x.Contractor)
                .Include(x => x.Products)
                .Where(x => x.SmallBillID==smallBillID)
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
                Data = MapListSmallBillDetailDTO(rs),
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

        public List<SmallBillDetailDTO> MapListSmallBillDetailDTO(List<SmallBillDetail> list)
        {
            List<SmallBillDetailDTO> rs = new();

            foreach (var item in list)
            {
                SmallBillDetailDTO dto = new()
                {
                    ContractorID = item.SmallBill.Bill.ContractorId,
                    EndDate = item.SmallBill.Bill.EndDate,
                    Id = item.Id,
                    Image = item.Products.Image,
                    Note = item.SmallBill.Bill.Note,
                    ProductBrand = item.Products.Brand,
                    ProductDescription = item.Products.Description,
                    ProductName = item.Products.Name,
                    StartDate = item.SmallBill.Bill.StartDate,
                    StoreID = item.SmallBill.Bill.StoreID,
                    StoreName = item.SmallBill.Bill.MaterialStore.User.FirstName + " " + item.SmallBill.Bill.MaterialStore.User.LastName,
                    TotalPrice = item.SmallBill.Bill.TotalPrice,
                    UnitPrice = item.Products.UnitPrice
                };
                rs.Add(dto);
            }
            return rs;
        }
    }
}
