using System;
using System.Collections.Generic;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            M3 m31 = new M3(110, "Blue", "M3");
            m31.RepairCar();

            m31.SetCarIDInfo(101, "Raj Patel");
            m31.GetCarIDInfo();
            
            Console.ReadLine();
           
        }
    }
}
