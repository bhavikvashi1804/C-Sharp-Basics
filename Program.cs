using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Post post1 = new Post("Thanks for birthday wish",true,"Raj Patel");
            Console.WriteLine(post1.ToString());
            Console.ReadLine();
        }
    }
}
