using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.BillModels
{
    public class SmallBillDetailDTO
    {
        public BigBillDetail? Bill { get; set; }
        public List<SmallBillDTO> Details { get; set; }
    }


    public class SmallBillDTO
    {
        public Status Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int Id { get; set; }
        public string? Note { get; set; }
        public DateTime? PaymentDate { get; set; }

        public List<ProductBillDetail>? ProductBillDetail { get; set; }

    }
}
