using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesHW
{
    public class Call
    {
        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        public string DialedNumber { get; set; }

        public TimeSpan Duration { get; set; }

        public Call(DateTime date, TimeSpan time, string dialedNumber, TimeSpan duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }
    }
}