using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace C_Sharp
{
    class ArrayListClass
    {
        public static void ExplainArrayList()
        {
            //declare array list
            ArrayList arrayList= new ArrayList();

            //other way to declare array list with total no of elements are fix
            ArrayList arrayList1 = new ArrayList(10);

            arrayList.Add(25);
            arrayList.Add(34.5);
            arrayList.Add("Bhavik");
            arrayList.Add(12);
            arrayList.Add("Vashi");


            Console.WriteLine("Print the Array List");
            foreach (object item in arrayList)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Remove the element 12 and then print the ArrayList");
            arrayList.Remove(12);
            foreach (object item in arrayList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Remove the element at index 0 and then print the ArrayList");
            arrayList.RemoveAt(0);
            foreach (object item in arrayList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Array List Length is: {0}", arrayList.Count);


            Console.WriteLine("Adding Object to ArrayList");
            arrayList.Add(new Number { N = 5 });
            foreach (object item in arrayList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }

        public static void ExplainList()
        {
            List<int> marks = new List<int>();
            marks.Add(78);
            marks.Add(82);
            marks.Add(99);
            marks.Add(77);
            marks.Add(78);

            foreach(int x in marks)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
            marks.Remove(78);
            for(int i = 0; i < marks.Count; i++)
            {
                Console.Write("{0} ", marks[i]);
            }
            Console.WriteLine();
            marks.RemoveAt(2);
            for (int i = 0; i < marks.Count; i++)
            {
                Console.Write("{0} ", marks[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Sort the List and then print");
            marks.Sort();
            for (int i = 0; i < marks.Count; i++)
            {
                Console.Write("{0} ", marks[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Check that whether 82 is present in list or not {0}:", marks.Contains(82));
            int index = marks.FindIndex(x=>x==82);
            Console.WriteLine("Index of 82 is {0}", index);

            marks.ForEach(x => Console.Write("{0} ",x));
        }
    }

    class Number
    {
        public int N { get; set; }

        public override String ToString()
        {
            return N.ToString();
        }
    }
}
