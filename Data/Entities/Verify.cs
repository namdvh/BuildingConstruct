using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Verify
    {
        public int Id { get; set; } 

        public string? FaceImage { get; set; }  

        public string? FrontID { get; set; }

        public string? BackID { get; set; }

        public User User { get; set; }


    }
}
