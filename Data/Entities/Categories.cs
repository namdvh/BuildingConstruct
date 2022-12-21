using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Categories
    {
        public int ID { get; set; }

        public string Name { get; set; }    

        public Enum.Type Type { get; set; }

        public List<ProductCategories> ProductCategories { get; set; }
    }
}
