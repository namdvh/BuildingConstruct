using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class AppliedPost
    {

        public int PostID { get; set; }

        public int BuilderID { get; set; }

        public int? GroupID { get; set; }

        public Group Group { get; set; }    

        public ContractorPost ContractorPosts { get; set; } 

        public Builder Builder { get; set; }

        public Status Status { get; set; }

        public DateTime AppliedDate { get; set; }



    }
}
