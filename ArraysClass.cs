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

        public static void MultiDimensionalArray()
        {
            int[,] array = new int[,]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            Console.WriteLine("Center value is {0}", array[1,1]);

            int[,,] array3d = new int[,,]
            {
                {
                    {1,2,4},
                    {4,5,4}
                },
                {
                    {21,43,4},
                    {34,546,4}
                }
            };
            Console.WriteLine("Print the 43 {0}", array3d[1, 0, 1]);


            //other way to create 2d array with defined rows and columns
            string[,] string2DArray = new string[3, 2] { {"Bhavik","Vashi" },{"Raj","Patel" }, {"Yash","Patel" } };
            //other way to create 2d array
            string[,] string2DArray1 = { { "Bhavik", "Vashi" }, { "Raj", "Patel" }, { "Yash", "Patel" } };


            //get the array dimension using .Rank
            Console.WriteLine("Dimension of 3d array is {0}", array3d.Rank);

        }


        public static void ExplainJaggedArray()
        {
            //jagged array means multiple array with in one array
            //declare jagged array
            int[][] jaggedArray = new int[3][];
            //here 3 specify that we have 3 arrays in that perticular array

            //create array for that each sub array
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            //assign value to that sub array
            jaggedArray[0] = new int[] { 1,2,3,4,5};
            jaggedArray[1] = new int[] { 6,7,8};
            jaggedArray[2] = new int[] { 9, 10 };

            //other way to assign value to jaggedArray
            int[][] jaggedArray2 = new int[][]
            {
                 new int[] { 1,2,3,4,5},
                 new int[] { 6,7,8},
                 new int[] { 9, 10 }
            };

            Console.WriteLine("Value at center is {0}", jaggedArray2[1][1]);

            Console.WriteLine("Print the Jagged array");

            for(int i=0;i< jaggedArray2.Length; i++)
            {
                for(int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.Write("{0} ", jaggedArray2[i][j]);
                }
                Console.WriteLine();
            }

        }
    }
}
