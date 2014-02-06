using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesHW
{
    public class GsmTest
    {
        private readonly Gsm[] testArray;

        public GsmTest()
        {
            this.testArray = new Gsm[] 
            {
                new Gsm(
                    "model",
                    "manufacturer",
                    10,
                    "someone",
                    new Battery(null,23,43,BatteryType.Unknown),
                    new Display()),
                new Gsm(
                    "Samsung Galaxy S4",
                    "Samsung",
                    1200,
                    "bai Ivan",
                    new Battery(
                        "somebatteryModel",
                        250,
                        12,
                        BatteryType.LiIon),
                    new Display(
                        5,
                        256)),
                new Gsm(
                    "Samsung Galaxy S5",
                    "Samsung",
                    2500,
                    "Gojo",
                    new Battery(
                        "someOtherBatteryModel",
                        550,
                        120,
                        BatteryType.NiCd),
                    new Display(
                        10,
                        25600)),
            };
        }

        public string ShowInfoTestArray()
        {
            var sb = new StringBuilder();
            foreach (var gsm in testArray)
            {
                sb.Append(gsm.ToString());
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public string ShowInfoIPhone4S()
        {
            return Gsm.IPhone4S.ToString();
        }
    }
}