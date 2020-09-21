using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MethodsClass.GreetPeople();
            MethodsClass.GreeetPeopleWithName("Bhavik");
            Console.WriteLine(MethodsClass.Add(10, 20));
            Console.WriteLine(MethodsClass.GetCompanyName());
            Console.ReadKey();
        }
    }
}
