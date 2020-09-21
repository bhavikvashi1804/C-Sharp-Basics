using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class VariableClass
    {
        public static void NumberDataType()
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

        public static void DataTypeString()
        {
            string userName = "Bhavik1804";
            string firstName = "Bhavik", lastName = "Vashi";
            Console.WriteLine("User Name is:"+userName);
            Console.WriteLine("My full name is " + firstName + " " +lastName);

            //toUpper()
            string fullName = firstName.ToUpper() + " " + lastName.ToUpper();
            Console.WriteLine(fullName);
            //toLower()
            string fullName1 = firstName.ToLower() + " " + lastName.ToLower();
            Console.WriteLine(fullName1);
        }

        public static void ConsoleMethods()
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

        public static void DoTypeConversion()
        {
            //Explicit Conversion
            double d1 = 15.678;
            int num1;
            //cast double to int
            num1 = (int)d1;
            Console.WriteLine(num1);

            //Implicit Conversion
            int num2 = 1234567;
            long longNum = num2;
            Console.WriteLine(longNum);

            float floatNum1 = 5.5f;
            double doubleNum1 = floatNum1;
            Console.WriteLine(doubleNum1);

            //type Conversion using inbuilt methods
            //any data type to String 
            int age = 33;
            bool child = false;
            string ageAsString = age.ToString();
            string childAsString = child.ToString();
            Console.WriteLine(ageAsString);
            Console.WriteLine(childAsString);
        }
    }
}
 