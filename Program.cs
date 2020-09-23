using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee michael = new Employee("Michael", "Miller", 40000);

            michael.Work();
            michael.Pause();

            Boss chuckNorris = new Boss("Ferrari", "Norris", "Chuck", 999999999);

            chuckNorris.Lead();

            Trainee michelle = new Trainee(32, 8, "Gartner", "Michelle", 10000);
            michelle.Learn();
            michelle.Work();
            Console.ReadKey();
        }
    }
}
