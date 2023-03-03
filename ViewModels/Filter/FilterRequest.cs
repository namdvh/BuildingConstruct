using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Filter
{
    public class FilterRequest
    {
        public string? Title { get; set; }

        public List<string>? Salary { get; set; }

        public List<Place>? Places { get; set; }

        public List<PostCategories>? Categories { get; set; }

        public int? Participant { get; set; }

        public bool? Accommodation { get; set; }

        public bool? Transport { get; set; }

        public Status? Status { get; set; }
    }
}
