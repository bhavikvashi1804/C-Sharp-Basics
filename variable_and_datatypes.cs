using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class Variable_Class
    {
        public static void printData()
        {
            int num1 = 13;
            int num2 = 7;
            int sum = num1 + num2;
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);

            double d1 = 3.5;
            double d2 = 3.227;
            double d3 = d1 + d2;
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + d3);
            Console.WriteLine("The sum of " + num1 + " and " + d1 + " is " + (num1 + d1));
            Console.WriteLine(d1 + " divided by " + d2 + " is " + (d1 / d2));
            Console.WriteLine(d1 + " divided by " + num1 + " is " + (d1 / num1));

            //you can not store the divided into int 
            //int x = d1 / num1;
            // for this you need type conversion 
        }            
    }
}
 