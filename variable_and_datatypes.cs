using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class Variable_Class
    {
        public static void printData()
        {
            int num1 = 13;
            int num2 = 7;
            int sum = num1 + num2;
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);

            double d1 = 3.5;
            double d2 = 3.227;
            double d3 = d1 + d2;
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + d3);
            Console.WriteLine("The sum of " + num1 + " and " + d1 + " is " + (num1 + d1));
            Console.WriteLine(d1 + " divided by " + d2 + " is " + (d1 / d2));
            Console.WriteLine(d1 + " divided by " + num1 + " is " + (d1 / num1));

            //you can not store the divided into int 
            //int x = d1 / num1;
            // for this you need type conversion 


            float f1 = 3.5f;
            float f2 = 4.5f;
            Console.WriteLine("The sum of " + f1 + " and " + f2 + " is " + (f1+f2));
        }

        public static void dataTypeString()
        {
            string user_name = "Bhavik1804";
            string first_name = "Bhavik", last_name = "Vashi";
            Console.WriteLine("User Name is:"+user_name);
            Console.WriteLine("My full name is " + first_name + " " +last_name);

            //toUpper()
            string full_name = first_name.ToUpper() + " " + last_name.ToUpper();
            Console.WriteLine(full_name);
            //toLower()
            string full_name1 = first_name.ToLower() + " " + last_name.ToLower();
            Console.WriteLine(full_name1);
        }

        public static void consoleMethods()
        {
            Console.Write("Hello");
            Console.Write("I am Bhavik Vashi");

            Console.WriteLine("");
            // to move the pointer to new line
            Console.WriteLine("Hello, I am Bhavik Vashi");
            Console.WriteLine("Good Morning");
            Console.WriteLine("");

            Console.Write("Enter a String and press enter:");
            string inputString = Console.ReadLine();
            Console.WriteLine("You have entered {0}",inputString);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            //clears the console buffer , bgcolor, color 
            //if we comment Console.Clear() then only text and its box area is colored 

            Console.Write("Enter a Key and press enter:");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII VALUE IS {0}",asciiValue);

            Console.Write("Enter any key to exit");
            Console.ReadKey();
            //this is going to wait until we enter any key
        }
    }
}
 