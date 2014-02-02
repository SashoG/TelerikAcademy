using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WorkDays
{
    class WorkDays
    {
        private static int NumberOfWorkDays(DateTime date)
        {
           
            DateTime[] publicHolydays = new DateTime[]
            {
                new DateTime(date.Year, 3, 3),
                new DateTime(date.Year, 5, 24),
                new DateTime(date.Year, 9, 6),
                new DateTime(date.Year, 9, 22),
                new DateTime(date.Year, 12, 25)
            };
            int workDayCounter = 0;
            for (DateTime i = DateTime.Now.Date; i < date; i=i.AddDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Sunday | i.DayOfWeek == DayOfWeek.Saturday)
                {
                    continue;
                }
                if (i.Date == publicHolydays[0] | i.Date == publicHolydays[1] | i.Date == publicHolydays[2] | i.Date == publicHolydays[3] | i.Date == publicHolydays[4])
                {
                    continue;
                }
                workDayCounter++;
            }
            return workDayCounter;
        }


        static void Main(string[] args)
        {
            System.Console.Write("Please enter date in the format mm,dd,yyyy: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("The number of workig days between {0} and {1} is: {2}",DateTime.Now.Date,date.Date,NumberOfWorkDays(date));
        }
    }
}
