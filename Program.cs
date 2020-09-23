using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            ImagePost imagePost1 = new ImagePost("Happy Birthday","Yash Patel",true,"https://www.a123/com");
            Console.WriteLine(imagePost1.ToString());
            Console.ReadLine();
        }
    }
}
