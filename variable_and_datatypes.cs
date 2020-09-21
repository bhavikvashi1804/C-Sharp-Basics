using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class Variable_Class
    {
        static int age1=20;
        public static void printData()
        { 
            int age = 15;
            // This is variable type of Integer and name is age

            Console.WriteLine(age);
            //  Print a variable age
            Console.WriteLine(age1);
            //print the variable which is declared outside of method
        }

        public static void printData1()
        {
            Console.WriteLine(age1);
            //in other method you can not use the variable which is declared in other method
            //but you can use the variable which is declared out side of any method 
        }
            
    }
}
