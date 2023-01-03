using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.ContractorPost
{
    public class AppliedPostRequest
    {
        public int PostId { get; set; }   
        public List<AppliedGroup>? GroupMember { get; set; } 
    }

    public class AppliedGroup
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public Guid TypeID { get; set; }
        public string VerifyId { get; set; }
    }
}
