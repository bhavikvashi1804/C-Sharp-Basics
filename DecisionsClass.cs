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
    }
}
