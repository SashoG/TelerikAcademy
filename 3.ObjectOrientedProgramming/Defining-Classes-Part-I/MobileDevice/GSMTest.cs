using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class GSMTest
    {
        private GSM[] gsmArray;

        public GSMTest()
        {
            this.gsmArray = new GSM[3] 
            { 
                new GSM("N90", "Nokia", 1300, "Alex"), 
                new GSM("N92", "Some", 300, "Dimo"), 
                new GSM("N95", "Noka", 3000, "Misho"), 
            };
        }

        public void DisplayInformation()
        {
            foreach (GSM item in gsmArray)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}
