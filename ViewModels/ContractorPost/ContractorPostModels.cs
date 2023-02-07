using Data.Entities;
using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.ContractorPost
{
    public class ContractorPostModels
    {
        public string Title { get; set; }

        public string ProjectName { get; set; }
        public List<TypeModels>? type { get; set; }

        public string Description { get; set; }
        public string? Benefit { get; set; }
        public string? Required { get; set; }

        public DateTime StarDate { get; set; }

        public DateTime EndDate { get; set; }

        public Place Place { get; set; }
        public List<ProductPost> ProductPost { get; set; }

        public PostCategories PostCategories { get; set; }

        public string Salaries { get; set; }

        public int NumberPeople { get; set; }
    }
}
