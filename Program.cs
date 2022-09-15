using System;

namespace RenewalMonth
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime startDate = new DateTime(2021, 08, 05);
            DateTime renewalDate = startDate.AddMonths(12);
            DateTime currentDate = DateTime.Now;


            int daysOfMonth = DateTime.DaysInMonth(2022, 09);
            Console.WriteLine("Total Number of Days in Month: {0} Days", daysOfMonth);


            int remainingDays = (int)(renewalDate - currentDate).TotalDays;
            int remianingPeriods = ((renewalDate.Year - currentDate.Year) * 12) + renewalDate.Month - currentDate.Month;
            Console.WriteLine("renewalDate : {0}", renewalDate);
            Console.WriteLine("remainingDays : {0}", remainingDays);
            Console.WriteLine("remianingPeriods : {0}", remianingPeriods);


            //Formula for get extra remainingDaysOfMonth in decimal form
            double remainingDaysOfMonth = (remainingDays - (double)(remianingPeriods * daysOfMonth)) / (double)daysOfMonth;
            Console.WriteLine("remainingDaysOfMonth : {0}", remainingDaysOfMonth);

            // adding whole and decimal months
            double remainingMonthInDouble = remainingDaysOfMonth + remianingPeriods;

            // for two decimal point
            remainingMonthInDouble = Math.Round(remainingMonthInDouble, 2);

            Console.WriteLine("remainingMonthInDouble : {0}", remainingMonthInDouble);

            //Hit ENTER to exit the program
            Console.ReadKey();
        }
    }
}
