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
    }
}
