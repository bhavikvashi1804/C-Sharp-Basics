using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class Calculator
    {
        
        public static void DoCalculations()
        {

            int ch;
            
            Console.WriteLine("1:Addition\n2:Subtraction\n3:Multipy\n4:Divide");
            Console.Write("Enter Your Choice:");

            ch = Int32.Parse(Console.ReadLine());

            int num1, num2;
            double result= 0;

            Console.Write("Enter Number 1:");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Number 2:");
            num2 = Int32.Parse(Console.ReadLine());


            if (ch == 1)
            {
                result = Add(num1, num2);
            }
            else if(ch == 2)
            {
                result = Subtract(num1, num2);
            }
            else if(ch == 3)
            {
                result = Multiply(num1, num2);
            }
            else if(ch == 4)
            {
                result = Divide(num1, num2);
            }
            else
            {
                Console.Write("Enter Proper Choice:");
            }
            Console.WriteLine("Result: " + result);
        }

        public static int Add(int num1,int num2)
        {
            return (num1 + num2);
        }

        public static int Subtract(int num1,int num2)
        {
            return (num1 - num2);
        }

        public static int Multiply(int num1,int num2)
        {
            return (num1 * num2);
        }

        public static double Divide(int num1,int num2)
        {
            return (num1 / num2);
        }
    }
}
