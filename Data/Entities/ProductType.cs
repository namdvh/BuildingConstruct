using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ProductType
    {
        
        public int Id { get; set; }

        public Products Products { get; set; }

        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public ProductTypeEnum Type { get; set; }

        public string? TypeName { get; set; }
    }
}
