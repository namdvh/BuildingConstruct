using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class BillDetail
    {
        public int Id { get; set; } 

        public int? BillID { get; set; }

        public Bill? Bills { get; set; }
        public int? SmallBillID { get; set; }

        public SmallBill? SmallBills { get; set; }

        public int? ProductID { get; set; }

        public Products? Products { get; set; }  

        public int Quantity { get; set; }

        public decimal Price { get; set; }  
        public int? ProductTypeId { get; set; }
        public ProductType ProductTypes { get; set; }
    }

}
