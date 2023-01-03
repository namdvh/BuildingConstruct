using Data.Enum;

namespace Data.Entities
{
    public class ContractorPost : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string ProjectName { get; set; }

        public string Description { get; set; }

        public List<ContractorPostSkill> PostSkills { get; set; }
        public List<ContractorPostProduct>? ContractorPostProducts { get; set; }
        public List<ContractorPostType>? ContractorPostTypes { get; set; }

        public List<PostCommitment>? PostCommitments { get; set; }
        public List<AppliedPost>? AppliedPosts { get; set; }


        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }

        public Status Status { get; set; }    

        public Place Place { get; set; }

        public PostCategories PostCategories { get; set; }

        public string Salaries { get; set; }

        public int ViewCount { get; set; }

        public int NumberPeople { get; set; }

        public int PeopeRemained { get; set; }

        public int ContractorID { get; set; }

        public Contractor Contractor { get; set; }

    }
}