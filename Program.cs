using System;
using System.Collections.Generic;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            var  cars= new List<Car>
            {
                new Audi(100,"White","A5"),
                new BMW(110,"Blue","M5")
            };
            cars[0].ShowDetails();
            cars[0].RepairCar();
            cars[1].ShowDetails();
            cars[1].RepairCar();
            
            Console.ReadLine();
           
        }
    }
}
