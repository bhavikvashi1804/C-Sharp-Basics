using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class DateTimeDemo
    {
        public static void CalAge()
        {
            Console.WriteLine("Enter your birthdate in YYYY/MM/DD format");
            string input = Console.ReadLine();
            DateTime dob= new DateTime();
            if(DateTime.TryParse(input, out dob))
            {
                var today = DateTime.Today;
                var age = today.Year - dob.Year;
                if (dob.Date > today.AddYears(-age)) age--;

                Console.WriteLine(age);

                TimeSpan daySpend = DateTime.Now.Subtract(dob);
                Console.WriteLine("Days spend: {0}", daySpend.Days);

            }
           



        }

        public static void DateBasics()
        {
            DateTime d1 = new DateTime(2019, 12, 04);
            Console.WriteLine(d1.ToString());
            Console.WriteLine("Years : "+d1.Year);
            Console.WriteLine("Month : "+d1.Month);
            Console.WriteLine("Day : "+d1.Day);

            Console.WriteLine("Today is "+DateTime.Now);
            Console.WriteLine("It is {0} o'clock {1} minutes and {2} seconds", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            Console.WriteLine("Day of week is " + DateTime.Now.DayOfWeek);
            Console.WriteLine("Tomorrow is " + DateTime.Now.AddDays(1));

            Console.WriteLine("In Feb 2020 total no of days " + DateTime.DaysInMonth(2020,02));
        }
    }
}
