using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Quiz
    {
        public int Id { get; set; } 

        public string? Name { get; set; }

        public Guid? TypeID { get; set; }

        public Type? Types { get; set; }

        public int PostID { get; set; }

        public decimal? DesiredResult { get; set; }

        public ContractorPost ContractorPost { get; set; }

        public DateTime LastModifiedAt { get; set; } = DateTime.Now;

        public List<Question> Questions { get; set; }
    }
}
