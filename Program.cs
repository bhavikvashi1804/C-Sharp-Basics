using System;
using System.Collections.Generic;

namespace C_Sharp
{
    enum Day { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Cube(10);
            shape1.GetInfo();
            Console.WriteLine("Volume of Cube is {0}",shape1.Volume());

            Shape shape2 = new Sphere(7);
            shape2.GetInfo();
            Console.WriteLine("Volume of Sphere is {0}", shape2.Volume());
            Console.Read();
        }
    }
}
