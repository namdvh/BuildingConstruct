using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.BillModels
{
    public class BillDTO
    {
        public int Id { get; set; }
        public string? Notes { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal TotalPrice { get; set; }
        public Status Status { get; set; }
        public BillType? BillType { get; set; }
        public List<ProductBillDTO> ProductBill { get; set; } 
        public List<SmallBill>? SmallBill { get; set; }

    }
}
