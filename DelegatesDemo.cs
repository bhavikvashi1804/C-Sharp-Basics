using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    
    class DelegatesDemo
    {

        public delegate double PerformCalculation(double x, double y);
        public static double AddTwoNumbers(double a, double b)
        {
            Console.WriteLine("{0}+{1}={2}",a,b, a + b);
            return a + b;
        }
        public static double SubTwoNumbers(double a, double b)
        {
            Console.WriteLine("{0}-{1}={2}",a,b, a - b);
            return a - b;
        }
        public static double MulTwoNumbers(double a, double b)
        {
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            return a * b;
        }

        public static void ExplainDelegates()
        {
            PerformCalculation performCalculation = AddTwoNumbers;
            Console.WriteLine(performCalculation(10, 21.9));
            performCalculation = SubTwoNumbers;
            Console.WriteLine(performCalculation(20, 10));


            PerformCalculation getSum = AddTwoNumbers;
            PerformCalculation getSub = SubTwoNumbers;
            PerformCalculation getMul = MulTwoNumbers;
            PerformCalculation performCalculation1 = getSum+ getSub;
            performCalculation1 += getMul;
            Console.WriteLine(performCalculation1(20, 10));
            //result at the end which method is called

            performCalculation1 -= getSub;
            Console.WriteLine(performCalculation1(20, 10));

        }


        public delegate string GetTextDelegate(string name);

        public static void ExplainAnonymousMethod()
        {
            GetTextDelegate getTextDelegate = delegate (string name)
            {
                return "Hello " + name;
            };

            Console.WriteLine(getTextDelegate("Bhavik"));

            Display(getTextDelegate);
        }


        public static void Display(GetTextDelegate getTextDelegate)
        {
            Console.WriteLine(getTextDelegate("Bhavik"));
        }
    }
}
