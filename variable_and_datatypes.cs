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

        public static void StringMethods()
        {
            string name = "Bhavik";
            // ToLower()
            Console.Write(" ToLower() ");
            Console.WriteLine(name.ToLower());
            // ToUpper()
            Console.Write(" ToUpper() ");
            Console.WriteLine(name.ToUpper());

            // Concat()
            Console.WriteLine("");
            Console.WriteLine(" Concat() ");
            string firstName = "Bhavik";
            string lastName = "Vashi";
            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine(fullName);

            // SubString()
            Console.WriteLine("");
            Console.WriteLine(" SubString() ");
            Console.WriteLine(fullName.Substring(2));
            Console.WriteLine(fullName.Substring(2, 4));

            //Trim()
            Console.WriteLine("");
            Console.WriteLine(" Trim() ");
            string myString1 = " Hello, My name is Bhavik ";
            Console.WriteLine(myString1);
            Console.WriteLine(myString1.Trim());

            // IndexOf()
            Console.WriteLine("");
            Console.WriteLine(" IndexOf() ");
            string myString2 = "Good morning";
            string myString3 = "My name is Bhavik. This is an Apple";
            Console.WriteLine(myString2.IndexOf('d')); //3
            Console.WriteLine(myString3.IndexOf("is")); //8

            // Format
            Console.WriteLine("");
            Console.WriteLine(" Format() ");
            string message = string.Format("Hello, my first name is {0} and my last name is {1}",firstName,lastName);
            Console.WriteLine(message);


            // IsNullOrWhiteSpace()
            Console.WriteLine("");
            Console.WriteLine(" IsNullOrWhiteSpace() ");
            string myString5 = "   ";
            string myString6 = "Hello";
            Console.WriteLine(myString5 + ":IsNullOrWhiteSpace():" + string.IsNullOrWhiteSpace(myString5));
            Console.WriteLine(myString6 + ":IsNullOrWhiteSpace():" + string.IsNullOrWhiteSpace(myString6));
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

        public static void ParseNumberFromString()
        {
            string myAge = "22";
            int age = Int32.Parse(myAge);
            Console.WriteLine(age + ", Data type :" + age.GetType().FullName);

            //here it do the string addition
            string fatherAge = "44";
            string result = myAge + fatherAge;
            Console.WriteLine(result);
            //prints 2244

            //now lets actual use of parseInt
            int result1 = Int32.Parse(myAge) + Int32.Parse(fatherAge);
            Console.WriteLine(result1);
            //prints 66

           //get the double number from string
            string salary = "32000.57";
            double salary1 = Double.Parse(salary);
            Console.WriteLine(salary1.GetType().FullName);
        }


        // constant as field
        const double PI = 3.14;
        public static void ConstantConcept()
        {
            Console.WriteLine(PI);
            //pi = 5.5;
            // you can not change its value 
            // you can use it but can not change its value
        }
    }
}
 