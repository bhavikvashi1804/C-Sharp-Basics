using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    enum Day { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
    class EmumDemo
    {
        public static void ExplainEnum()
        {
            Day d1 = Day.Mon;
            Day d2 = Day.Fri;
            Console.WriteLine(d1 == d2);
            Console.WriteLine(d1);
            Console.WriteLine((int)d1);
        }
    }
}
