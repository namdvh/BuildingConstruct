using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class DateTimes
    {
        public DateTime realtime { get; set; }

        public DateTimes(DateTime realtime)
        {
            this.realtime =TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, TimeZoneInfo.FindSystemTimeZoneById("Asia/Bangkok")); ;
        }
    }
}
