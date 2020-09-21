using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class ExceptionClass
    {
        public static void Divide(int d1, int d2)
        {
            int result = 0;
            try
            {
                result = d1 / d2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Result {0}", result);
            }
        }
    }
}
