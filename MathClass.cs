using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class MathClass
    {
        public static void ExplainMathClass()
        {
            Console.WriteLine("Ceiling: {0}", Math.Ceiling(12.7));
            Console.WriteLine("Floor: {0}", Math.Floor(12.7));

            Console.WriteLine("Min of {0} and {1} is {2}", 10, 7, Math.Min(10, 7));
            Console.WriteLine("Max of {0} and {1} is {2}", 10, 7, Math.Max(10, 7));

            Console.WriteLine("3 to power 5 is {0}", Math.Pow(3, 5));
            Console.WriteLine("Value of PI is {0}", Math.PI);

            Console.WriteLine("Square root of 25 is {0}", Math.Sqrt(25));

            Console.WriteLine("Always Positive {0}", Math.Abs(-5));

            Console.WriteLine("Cos of 1 is {0}", Math.Cos(1));
        }
    }
}
