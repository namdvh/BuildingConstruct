using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.ProductSystems
{
    public class ProductSystemDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string? Image { get; set; }

        public string? Description { get; set; }

        public string? Brand { get; set; }
        public bool FromSystem { get; set; }

        public List<ProducSystemCategoriesDTO>? ProductSystemCategories { get; set; }
        public List<Data.Entities.Categories>? Categories { get; set; }

    }
    public class ProductSystemRequestDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string? Image { get; set; }

        public string? Description { get; set; }

        public string? Brand { get; set; }

        public List<int>? CategoriesID { get; set; }

    }
    public class ProducSystemCategoriesDTO
    {
        public int CategoriesID { get; set; }

        public int ProductSystemID { get; set; }
    }

}
