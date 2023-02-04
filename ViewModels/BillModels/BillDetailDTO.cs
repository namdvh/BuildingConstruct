using Data.Entities;
using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.BillModels
{
    public class BillDetailDTO
    {
        public BigBillDetail? Bill { get; set; }

        public List<ProductBillDetail>? Products { get; set; }

    }


    public class ProductBillDetail
    {
        public string? ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string? Image { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductBrand { get; set; }
        public decimal? BillDetailTotalPrice { get; set; }
        public decimal? BillDetailQuantity { get; set; }
    }

    public class BigBillDetail
    {
        public int Id { get; set; }

        public string? Note { get; set; }

        public DateTime? PaymentDate { get; set; }
        public MonthOfInstallment? MonthOfInstallment { get; set; }

        public BillType? Type { get; set; }

        public Status Status { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal TotalPrice { get; set; }

        public int ContractorId { get; set; }

        public int? StoreID { get; set; }

        public string? StoreName { get; set; }

    }
}
