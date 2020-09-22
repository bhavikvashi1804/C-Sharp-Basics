using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box(4, 5, 10);

            Console.WriteLine("Width of Box is {0}", b1.Width);
            b1.Width = 2;
            Console.WriteLine("Width of Box is {0}", b1.Width);

            b1.BoxName = "Amazon";
            Console.WriteLine(b1.BoxName);

            try
            {
                b1.Height = -10;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
           
            Console.ReadKey();
        }
    }
}
