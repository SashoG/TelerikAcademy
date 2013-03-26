using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Override ToString()
            Console.WriteLine("*****Display information about GSM instance*****");
            GSM gsm = new GSM("N90", "Nokia");
            Console.WriteLine(gsm.ToString());
            Console.WriteLine();


            //Test GSM Class
            Console.WriteLine("*****TEST OF THE GSM CLASS*****");
            GSMTest gsmtest = new GSMTest();
            gsmtest.DisplayInformation();
            Console.WriteLine();

            //Test Call History
            //Instance of GSM class
            GSM justGsm = new GSM("Some model", "some manifacturer", 1000, "An Owner");
            
            //Add some calls
            System.DateTime date1 = new System.DateTime(1996, 6, 3, 22, 15, 0);
            System.DateTime date2 = new System.DateTime(1996, 12, 6, 13, 2, 0);
            System.DateTime date3 = new System.DateTime(1996, 10, 12, 8, 42, 0);
            justGsm.AddCall(justGsm.CallHistory, new Call(date1.Date, date1.TimeOfDay, 0888888888, date2.Subtract(date1)));
            justGsm.AddCall(justGsm.CallHistory, new Call(date2.Date, date2.TimeOfDay, 0765432111, date3.Subtract(date1)));
            justGsm.AddCall(justGsm.CallHistory, new Call(date3.Date, date3.TimeOfDay, 0989765432, date2.Subtract(date3)));
            //display call info
            foreach (Call call in justGsm.CallHistory)
            {
                call.CallInfo();
            }
            //total price of calls
            Console.WriteLine("Total price of calls: {0} ",justGsm.TotalPriceOfCalls(justGsm.CallHistory)); 
           
            //find longest call
           //TODO 
            
            //remove longest call
            //TODO
            //clear call history
            justGsm.ClearCallHistory(justGsm.CallHistory);
            Console.WriteLine("***Clearing call history***");
            //display call info
            foreach (Call call in justGsm.CallHistory)
            {
                call.CallInfo();
            }

        }
    }
}
