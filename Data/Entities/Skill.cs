﻿namespace Data.Entities
{
    public class Skill
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<BuilderSkill> BuilderSkills { get; set; }
        public List<ContractorPostSkill> ContractorPostSkills { get; set; }

    }
}