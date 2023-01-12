using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Cart
    {
        public Guid UserID { get; set; }

        public int ProductID { get; set; }

        public User User { get; set; }  

        public Products Products { get; set; }

        public int Quantity { get; set; }

        public DateTime LastModifiedAt { get; set; } = DateTime.Now;

    }
}
