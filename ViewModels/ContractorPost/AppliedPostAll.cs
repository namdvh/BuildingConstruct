using Data.Enum;

namespace ViewModels.ContractorPost
{
    public class AppliedPostAll
    {
        public int? PostId { get; set; }

        public string? Avatar { get; set; }

        public string? Title { get; set; }

        public string? ProjectName { get; set; }

        public string? Description { get; set; }

        public string? AuthorName { get; set; }

        public DateTime StarDate { get; set; }

        public DateTime EndDate { get; set; }

        public Place Place { get; set; }

        public DateTime AppliedDate { get; set; }

        public decimal? WishSalary { get; set; }

    }
}
