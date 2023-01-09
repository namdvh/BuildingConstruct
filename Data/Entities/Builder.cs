﻿using Data.Enum;

namespace Data.Entities
{
    public class Builder:BaseEntity
    {
        public int Id { get; set; }

        public string? YearOfExperience { get; set; }

        public string? Certificate { get; set; }

        public int? ExperienceDetail { get; set; }

        public Place? Place { get; set; }

        public List<BuilderSkill>? BuilderSkills { get; set; }

        public User? User { get; set; }

        public List<BuilderPost>? Posts { get; set; }

        public Guid? TypeID { get; set; }

        public Type Type { get; set; }
        
        public List<Group>? Groups { get; set; }

        public List<AppliedPost>? AppliedPosts { get; set; }
        
    }
}