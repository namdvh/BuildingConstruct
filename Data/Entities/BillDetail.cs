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

        public int BillId { get; set; }

        public Bill? Bill { get; set; }

        public int ProductID { get; set; }

        public Products? Products { get; set; }  

        public int Quantity { get; set; }

        public decimal Price { get; set; }  
    }

}
