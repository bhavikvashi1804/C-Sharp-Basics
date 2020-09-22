using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box(4, 5, 10);
            b1.DisplayInfo();

            try
            {
                b1.SetHeight(-10);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
           
            Console.ReadKey();
        }
    }
}
