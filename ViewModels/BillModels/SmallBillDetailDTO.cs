using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.BillModels
{
    public class SmallBillDetailDTO
    {

        public int Id { get; set; }

        public int? StoreID { get; set; }
        public string? StoreName { get; set; }

        public int? ContractorID { get; set; }

        public string? Note { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal TotalPrice { get; set; }
        public decimal UnitPrice { get; set; }
        public string? Image { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductBrand { get; set; }
        public string? ProductName { get; set; }
    }
}
