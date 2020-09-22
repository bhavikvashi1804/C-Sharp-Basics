using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human bhavik = new Human("Bhavik", "Vashi", "Blue", 23);
            bhavik.IntroduceMySelf();

            Human raj = new Human("Raj", "Patel");
            raj.IntroduceMySelf();

            Human bhavik1 = new Human(bhavik);
            bhavik1.IntroduceMySelf();
           
            Console.ReadKey();
        }
    }
}
