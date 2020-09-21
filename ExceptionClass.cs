using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class ExceptionClass
    {

        public static void Divide(int d1,int d2)
        {
            int result = 0;
            try
            {
                if(d2 == 0)
                {
                    throw new DivideByZeroException("Second Number Must not be 0");
                }
                else
                {
                    result = d1 / d2;
                }
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Result {0}", result);
            }
        }


        public static void DemoUserDefinedException() 
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
        }
    }

    //UserDefine Exception
    //1 Create a class with extends Exception Class 
    //2 Throw exception when want to throw cased on condition
    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {

        }
    }

    public class Temperature
    {
        int temperature = 0;

        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperature);
            }
        }
    }
}
