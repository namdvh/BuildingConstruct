using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.ContractorPost
{
    public class ContractorPostProductDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitInStock { get; set; }

        public string? Image { get; set; }

        public string? Description { get; set; }

        public string? Brand { get; set; }

        public int? MaterialStoreID { get; set; }

        public Data.Entities.MaterialStore MaterialStore { get; set; }

        public List<ProductCategories>? ProductCategories { get; set; }
    }
}
