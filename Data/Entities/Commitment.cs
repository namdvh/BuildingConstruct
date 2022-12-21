using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Commitment
    {
        public int Id { get; set; }

        public string? OptionalTerm { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Status Status { get; set; }

        public List<PostCommitment>? PostCommitments { get; set; }
    }
}
