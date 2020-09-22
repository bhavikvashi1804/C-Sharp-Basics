using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class ArraysClass
    {

        //declare , initialize and length of an array
        public static void ArrayBasics()
        {
            //declare and initialize the array
            int[] grades= new int[5];

            //assign a value to element of array
            grades[0] = 10;
            grades[1] = 20;
            grades[2] = 15;
            grades[3] = 12;
            grades[4] = 17;

            //access the one element
            Console.WriteLine("Element at 3 index: {0}", grades[3]);

            Console.WriteLine("The array is");
            //access the value of array
            for(int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }



            //other way to initialize array
            int[] marks = { 10, 12, 13, 14, 15 };
            int[] marks1 = new int[] { 10, 12, 13, 14, 15,16 };

            //get the length of array
            Console.WriteLine("Length of marks array: {0}", marks.Length);
        }

        public static void ExplainForEach()
        {
            int[] numbers = new int[10];

            for(int i = 0; i < 10; i++)
            {
                numbers[i] = i+1;
            }

            Console.WriteLine("Array is");
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element at {0} is {1}", i, numbers[i]);
            }

            Console.WriteLine("Print the array using for each loop");
            int counter = 0;
            foreach(int num1 in numbers)
            {
                Console.WriteLine("Element at {0} is {1}", counter++, num1);
            }

            //for each task
            string[] friends = {"Raj","Yash","Meet","Tejoy","Bhargav" };

            foreach(string oneFriend in friends)
            {
                Console.WriteLine("Hello {0}", oneFriend);
            }
            
        }
    }
}
