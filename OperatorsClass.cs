using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class OperatorsClass
    {

        public static void ExplainOperators()
        {
            int num1 = 5, num2 = 6;
            num1 += num2;
            Console.WriteLine(num2);

            bool isValid = true;
            Console.WriteLine(!isValid);

            //post increment
            int num3 = 4;
            Console.WriteLine(num3); //4
            Console.WriteLine(num3++); //4
            Console.WriteLine(num3); //5

            //pre increment
            int num4 = 4;
            Console.WriteLine(num4); //4
            Console.WriteLine(++num4); //5
            Console.WriteLine(num4); //5

            //post decrement 
            int num5 = 4;
            Console.WriteLine(num5); //4
            Console.WriteLine(num5--); //4
            Console.WriteLine(num5); //3


            //pre decrement
            int num6 = 4;
            Console.WriteLine(num6); //4
            Console.WriteLine(--num6); //3
            Console.WriteLine(num6); //3

            //add , sub, mul, div , modulo
            int num7 = 8, num8 = 2;
            Console.WriteLine(num7 + " + " + num8 + " = "+(num7 + num8));
            Console.WriteLine(num7 + " - " + num8 + " = " + (num7 - num8));
            Console.WriteLine(num7 + " * " + num8 + " = " + (num7 * num8));
            Console.WriteLine(num7 + " / " + num8 + " = " + (num7 / num8));
            Console.WriteLine(num7 + " % " + num8 + " = " + (num7 % num8));


            //relational Operators
            Console.WriteLine("7 > 8" + (7 > 8));
            Console.WriteLine("7 < 8" + (7 < 8));
            Console.WriteLine("8 >= 8" + (8 >= 8));
            Console.WriteLine("7 <= 8" + (7 <= 8));

            //equality operator
            Console.WriteLine("8 == 8" + (8 == 8));
            Console.WriteLine("8 != 7" + (8 != 7));


            //Logical Operator
            Console.WriteLine("True && True: " + (true && true));
            Console.WriteLine("True || False: "+ (true || false));


            //Ternary Operator
            //int x = condition ? valueIfConditionIsTrue: valueIfConditionIsTrue ;
            int x = (5 > 2) ? 1 : 0;
            int y = (5 < 2) ? 1: 0;
            Console.WriteLine(" int x = (5 > 2) ? 1 : 0;" + x);
            Console.WriteLine(" int y = (5 < 2) ? 1 : 0;" + y);


        }
    }
}
