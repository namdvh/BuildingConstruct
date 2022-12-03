using Data.Enum;

namespace Data.Entities
{
    public class BuilderPost : BaseEntity
    {
        public int Id { get; set; }

        public PostCategories PostCategories { get; set; }
        public Place Place { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Field { get; set; }

        public int Views { get; set; }

        public int BuilderID { get; set; }
        public Builder Builder { get; set; }
    }
}