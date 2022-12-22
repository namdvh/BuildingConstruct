using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Commitment
{
    public class CommitmentGroup
    {
        public string Name { get; set; } 

        public DateTime DOB { get; set; }

        public int TypeID { get; set; }

        public string IdNumber { get; set; }
    }
}
