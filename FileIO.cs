using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace C_Sharp
{
    class FileIO
    {
        public static void ReadAFileInString()
        {
            string text = System.IO.File.ReadAllText(@"D:\bhavik.txt");
            Console.WriteLine(text);
        }

        public static void ReadAFileLineByLine()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\bhavik.txt");
            foreach(string line in lines)
            {
                Console.WriteLine("{0} {1}", line, line.Length);
            }
        }

        public static void WriteStringsInFile()
        {
            string[] lines = { "Hello", "My name is Raj Patel", "I am IT Expert" };
            File.WriteAllLines(@"D:\bhavik1.txt", lines);
        }

        public static void WriteFile1()
        {
            Console.WriteLine("Enter a file name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Enter the file content");
            string fileContent = Console.ReadLine();
            File.WriteAllText(@"D:\" + fileName + ".txt", fileContent);
        }

        public static void WriteFile2()
        {
            string[] lines = { "Bhavik", "Vashi", "Raj", "Patel" };
            using (StreamWriter streamWriter = new StreamWriter(@"D:\bhavik2.txt"))
            {
                foreach(string line in lines)
                {
                    if (!line.Contains("Vashi"))
                    {
                        streamWriter.WriteLine(line);
                    }
                }
            }

        }

        //append to file
        public static void WriteFile3()
        {
            string[] lines = { "Yash","Patel" };
            using (StreamWriter streamWriter = new StreamWriter(@"D:\bhavik2.txt",true))
            {
                foreach (string line in lines)
                {
                    
                   streamWriter.WriteLine(line);
                    
                }
            }
        }
    }
}
