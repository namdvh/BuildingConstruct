using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.ContractorPost
{
    public class AppliedPostRequest
    {
        public int PostContractorID { get; set; }   
        public List<AppliedGroup>? Groups { get; set; } 
    }

    public class AppliedGroup
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public int TypeID { get; set; }
        public string IdNumber { get; set; }
    }
}
