﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class LoopClass
    {
        public static void ExplainForLoop()
        {
            Console.WriteLine("For Loop with increment");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello {0}", i);
            }

            Console.WriteLine();
            Console.WriteLine("For Loop with increment the counter value by 5");
            for (int i = 5; i < 51; i += 5)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("For Loop with decrement");
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine("Hello {0}", i);
            }

            Console.WriteLine();
            Console.WriteLine("Print odd numbers using for loop");
            for( int i =  1; i < 21; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void ExplainDoWhileLoop()
        {
            int counter = 0;
            do
            {
                Console.WriteLine(counter++);
            } while (counter < 5);


            Console.WriteLine("Do While loop checks the condition after code is run");
            Console.WriteLine("It executes once even if condition if false");
            counter = 15;
            do
            {
                Console.WriteLine(counter++);
            } while (counter < 5);

        }


        public static void ExplainWhileLoop()
        {
            int counter = 0;
            Console.WriteLine("While Loop Check the condition at first");
            while(counter < 5)
            {
                Console.WriteLine(counter++);
            } 

        }

        public static void ExplainBreakAndContinue()
        {
            for(int i = 1; i <= 10; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Counter at {0} and we want to skip it", i);
                    continue;
                }
                if (i == 5)
                {
                    Console.WriteLine("Counter at {0} and we want to stop at here", i);
                    break;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("Print the Even number using countinue");
            for(int i = 1; i < 11; i++)
            {
                if(i%2 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        public static void LoopTask()
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while (input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("Please enter -1 once you are ready to calculate the average");

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("--------------------------------------------");
                    double average = (double)total / (double)count;
                    Console.WriteLine("The average score of your students is {0}", average);
                }
                if (int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    total += currentNumber;
                }
                else
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20!");
                    }
                    continue;
                }

                count++;

            }
        }
    }
}
