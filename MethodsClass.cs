using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace C_Sharp
{
    class MethodsClass
    {
        
        //method with no args and no return type
        public static void GreetPeople()
        {
            Console.WriteLine("Good Morning");
        }

        //method with argument but no return type
        public static void GreeetPeopleWithName(string name)
        {
            Console.WriteLine("Good Morning " + name);
        }


        //method with argument and return type
        public static int Add(int num1,int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        //method with no argument but has return type
        public static string GetCompanyName()
        {
            return "GCET";
        }
    }
}
