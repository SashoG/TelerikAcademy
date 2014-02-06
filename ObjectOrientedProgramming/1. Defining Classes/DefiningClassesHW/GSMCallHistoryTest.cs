using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesHW
{
    public class GSMCallHistoryTest
    {
        public Gsm TestGsmClass = new Gsm("model",
            "manufacturer",
            10,
            "someone",
            new Battery(null,23,43,BatteryType.Unknown),
            new Display());

        public GSMCallHistoryTest()
        {
            this.TestGsmClass.AddCallToHistory(
                new Call(
                    DateTime.Now.Date,
                    DateTime.Now.TimeOfDay,
                    "099999999999",
                    TimeSpan.FromMinutes(50)));
            this.TestGsmClass.AddCallToHistory(
                new Call(
                    DateTime.Now.Date,
                    DateTime.Now.TimeOfDay,
                    "09999999",
                    TimeSpan.FromMinutes(100)));
            this.TestGsmClass.AddCallToHistory(
                new Call(
                    DateTime.Now.Date,
                    DateTime.Now.TimeOfDay,
                    "09999999",
                    TimeSpan.FromMinutes(100)));
        }
    }
}