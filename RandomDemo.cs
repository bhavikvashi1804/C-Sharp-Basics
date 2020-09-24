using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class RandomDemo
    {

        public static void ExplainRandom()
        {
            Random dice = new Random();

            Console.WriteLine(dice.Next());
            Console.WriteLine(dice.Next(1,6)); // min , max
            Console.WriteLine(dice.Next(6)); // max
        }
    }
}
