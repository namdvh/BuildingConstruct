using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Users
{
    public class UserLoginDTO
    {
        public int AccessCount { get; set; }
        public DateTime Time { get; set; }
    }
    public class AccessSatisticDTO
    {
        public int AccessCount { get;set;}
        public string Time { get; set; }
    }
}
