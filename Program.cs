using System;
using System.Collections.Generic;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Car bmw1 = new BMW(110, "Blue", "M5");
            bmw1.ShowDetails();
            bmw1.RepairCar();

            BMW bmw2 = new BMW(120, "Yellow", "X1");
            bmw2.ShowDetails();
            bmw2.RepairCar();
            
            Console.ReadLine();
           
        }
    }
}
