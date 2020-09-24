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
            DateTime dob = Convert.ToDateTime(input) ;
            var today = DateTime.Today;
            var age = today.Year - dob.Year;
            if (dob.Date > today.AddYears(-age)) age--;

            Console.WriteLine(age);



        }
    }
}
