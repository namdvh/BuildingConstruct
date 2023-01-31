using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.BillModels
{
    public class SmallBill
    {
        public string? Notes { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double TotalPrice { get; set; }
        public int BillId { get; set; }
        public List<ProductBillDTO> SmallProduct { get; set; }

    }
}
