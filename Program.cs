using System;
using System.Collections.Generic;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dob;
            Console.WriteLine("Enter your birthdate");
            dob = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Age {0}",GetAge(dob));


            Console.ReadLine();
        }

        public static int GetAge(DateTime dob)
        {
            var today = DateTime.Today;
            var age = today.Year - dob.Year;
            if (dob.Date > today.AddYears(-age)) age--;

            return age;
        }
    }
}
