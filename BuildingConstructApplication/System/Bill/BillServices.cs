using Data.DataContext;
using Data.Entities;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using ViewModels.BillModels;

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
                    billDetail.BillId = bill.Id;
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
                            foreach (var i in item.SmallProductDetail)
                            {
                                var smallBillDetail = new SmallBillDetail();
                                smallBillDetail.SmallBillID = smallBill.Id;
                                smallBillDetail.ProductID = i.ProductId;
                                smallBillDetail.Quantity = i.Quantity;
                                smallBillDetail.Price = i.Price;
                                _context.SmallBillDetails.Add(smallBillDetail);
                                _context.SaveChanges();
                            }
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
    }
}
