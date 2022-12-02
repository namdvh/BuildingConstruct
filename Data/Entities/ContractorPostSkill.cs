namespace Data.Entities
{
    public class ContractorPostSkill
    {
        public int PostID { get; set; }

        public int SkillID { get; set; }

        public ContractorPost ContractorPost { get; set; }

        public Skills Skills { get; set; }
    }
}