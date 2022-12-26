using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ProductSystemCategories
    {
        public int CategoriesID { get; set; }

        public int ProductSystemID { get; set; }

        public ProductSystem ProductSystem { get; set; }

        public Categories Categories { get; set; }
    }
}
