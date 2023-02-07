using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Categories;

namespace ViewModels.MaterialStore
{
    public class ProductDetailDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitInStock { get; set; }

        public List<string>? Image { get; set; }

        public string? Description { get; set; }

        public string? Brand { get; set; }

        public int SoldQuantities { get; set; }

        public MaterialStoreDTO Store { get; set; }

        public List<CategoryDTO>? ProductCategories { get; set; }
        public Guid? CreatedBy { get; set; }
    }
}
