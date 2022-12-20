using Data.Enum;

namespace Data.Entities
{
    public class Builder:BaseEntity
    {
        public int Id { get; set; }

        public int Experience { get; set; }

        public Place? Place { get; set; }

        public List<BuilderSkill>? BuilderSkills { get; set; }

        public User? User { get; set; }

        public List<BuilderPost> Posts { get; set; }
    }
}