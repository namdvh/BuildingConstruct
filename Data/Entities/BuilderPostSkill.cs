using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class BuilderPostSkill
    {
        public int BuilderPostID { get; set; }

        public int SkillID { get; set; }

        public BuilderPost BuilderPost { get; set; }

        public Skill Skills { get; set; }

        
    }
}
