using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    public class Call
    {
        
        //Date reference of the call
        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        //Time reference of the call
        private TimeSpan time;
        public TimeSpan Time
        {
            get { return time; }
            set { time = value; }
        }

        //Number dialed if any 
        private decimal dialedNumber;
        public decimal DialedNumber
        {
            get { return dialedNumber; }
            set { dialedNumber = value; }
        }

        //Duration of the call
        private TimeSpan duration;
        public TimeSpan Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        //constructor of the call class
        public Call(DateTime date, TimeSpan time, decimal dialedNumber, TimeSpan duration)
        {
            this.date = date.Date;
            this.time = time;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }

         //Display information for call 
        public void CallInfo()
        {
		        Console.WriteLine("Date of call: {0}\ntime of call: {1}\ndialed number: {2}\nduration: {3}", this.date, this.time, this.dialedNumber, this.duration);
        }
        
    }
}
