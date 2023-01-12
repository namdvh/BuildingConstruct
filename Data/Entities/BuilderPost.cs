using Data.Enum;

namespace Data.Entities
{
    public class BuilderPost : BaseEntity
    {
        public int Id { get; set; }

        public PostCategories PostCategories { get; set; }
        public List<BuilderPostType>? BuilderPostTypes { get; set; }
        public List<BuilderPostSkill>? BuilderPostSkills { get; set; }
        public List<Save>? Saves { get; set; }
        public Place Place { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Salaries { get; set; }
        public Status Status { get; set; }
        public int Views { get; set; }

        public int BuilderID { get; set; }
        public Builder Builder { get; set; }
    }
}