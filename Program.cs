using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            VideoPost videoPost1 = new VideoPost("Happy Birthday","Meet Patel","https://sdsad.com",true,120);
            Console.WriteLine(videoPost1);


            videoPost1.PlayVideo();
            Console.WriteLine("Press any key to stop video");
            Console.ReadLine();
            videoPost1.StopVideo();


            Console.ReadLine();
        }
    }
}
