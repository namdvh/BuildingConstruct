using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ProductSystemCategories
    {
        public int SystemCategoriesID { get; set; }

        public int ProductSystemID { get; set; }
        public ProductSystem ProductSystem { get; set; }

        public SystemCategories SystemCategories { get; set; }
    }
}
