using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class SmallBill
    {
        public int Id { get; set; }

        public string? Note { get; set; }

        public DateTime? PaymentDate { get; set; }

        public Status Status { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal TotalPrice { get; set; }

        public int BillID { get; set; }

        public Bill? Bill { get; set; }

        public List<SmallBillDetail>? Details { get; set; }

    }
}
