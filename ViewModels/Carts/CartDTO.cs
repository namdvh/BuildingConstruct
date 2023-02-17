using Data.Entities;
using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Carts
{
    public class CartDTO
    {

        public int ProductID { get; set; }

        public string? ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int? UnitInStock { get; set; }

        public string? Image { get; set; }

        public int? Quantity { get; set; }

        public int? MaterialStoreID { get; set; }   

        public string? MaterialStoreName { get; set; }

        public DateTime LastModifiedAt { get; set; } 

        //public ProductTypeEnum? Type { get; set; }

        public int? TypeID { get; set; }

        public string? TypeName { get; set; }
    }
}
