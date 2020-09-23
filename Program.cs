using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Notification notification1 = new Notification("Raj Patel","How are you?","20-07-2020");
            Console.WriteLine(notification1.getDate()); 
            notification1.showNotification();
            Console.ReadKey();
        }
    }
}
