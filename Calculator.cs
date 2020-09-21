using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class Calculator
    {
        
        public static void DoCalculations()
        {

            int ch=8;
            int num1=0, num2=0;
            double result = 0;

            Console.WriteLine("1:Addition\n2:Subtraction\n3:Multipy\n4:Divide");
            Console.Write("Enter Your Choice:");

            try
            {
                ch = Int32.Parse(Console.ReadLine());
                Console.Write("Enter Number 1:");
                num1 = Int32.Parse(Console.ReadLine());
                Console.Write("Enter Number 2:");
                num2 = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally always executed, even there is exception or not");
                // this is normally used to do clean up process
                //close a file 
            }
            


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
            double d1= (double)num1, d2 =(double) num2;
            return (d1 / d2);
        }
    }
}
