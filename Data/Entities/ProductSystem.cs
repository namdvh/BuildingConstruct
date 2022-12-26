using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ProductSystem
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string? Image { get; set; }

        public string? Description { get; set; }

        public string? Brand { get; set; }
        public bool FromSystem { get; set;}

        public List<ContractorPostProduct>? ContractorPostProducts { get; set; }

        public List<ProductSystemCategories>? ProductSystemCategories { get; set; }
    }
}
