using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box(4, 5, 10);
            Console.WriteLine("Width of Box is {0}", b1.Width);
        }
    }
}
