using Data.Entities;
using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.ContractorPost
{
    public class ContractorPostDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ProjectName { get; set; }

        public string Description { get; set; }

        public DateTime StarDate { get; set; }

        public DateTime EndDate { get; set; }

        public Place Place { get; set; }

        public PostCategories PostCategories { get; set; }

        public string? Salaries { get; set; }

        public int ViewCount { get; set; }

        public int NumberPeople { get; set; }

        public int ContractorID { get; set; }

        public string? Avatar { get; set; }

    }
}
