using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a object of Human Class
            Human h1 = new Human();
            //access the public variable
            h1.fullName = "Bhavik Vashi";
            //call the class method
            h1.IntroduceMySelf();

            Human h2 = new Human();
            h2.fullName = "Raj Patel";
            h2.IntroduceMySelf();

            Console.ReadKey();
        }
    }
}
