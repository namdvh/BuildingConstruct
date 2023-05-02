using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.ContractorPost
{
    public class TypeAdmins
    {
        public Guid? id { get; set; }
        public string? name { get; set; }
        public List<SkillArr> SkillArr { get; set; }
        public Status Status { get; set; }
    }
}
