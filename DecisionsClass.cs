using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class DecisionsClass
    {
        public static void ExplainIfElse()
        {
            Console.Write("Enter your age:");
            string s1 = Console.ReadLine();
            int temp,age;
            bool parseDone = int.TryParse(s1,out temp);

            if (parseDone)
            {
                age = temp;
                //if
                if (age > 18)
                {
                    Console.WriteLine("You are allowed to register");
                }


                //if else
                if (age > 18)
                {
                    Console.WriteLine("You are allowed to register");
                }
                else
                {
                    Console.WriteLine("You are not allowed to register");
                }

                //if else if
                if (age < 18)
                {
                    Console.WriteLine("You are child");
                }
                else if (age < 30)
                {
                    Console.WriteLine("You are teenager");
                }
                else
                {
                    Console.WriteLine("You are man");
                }
            }
            else
            {
                Console.WriteLine("Please check the entered data");

            }

            
        }


        public static void ExplainSwitch()
        {
            int age = 12;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party in club");
                    break;
                case 18:
                    Console.WriteLine("Focus on your JEE");
                    break;
                case 22:
                    Console.WriteLine("Focus on your job");
                    break;
                default:
                    Console.WriteLine("Do what ever you want");
                    break;
            }
        }


        public static void ExplainTernaryOperator()
        {
            Console.Write("Enter temperature:");
            int temperature = int.Parse(Console.ReadLine());

            string stateOfMatter = temperature > 100 ? "Gas" : temperature < 0 ? "Solid" : "Matter";
            Console.WriteLine(stateOfMatter);
        }
    }
}
