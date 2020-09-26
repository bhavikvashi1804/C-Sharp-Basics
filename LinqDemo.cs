using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp
{
    class LinqDemo
    {

        public static void LinqDemo1()
        {
            UniversityManager universityManager = new UniversityManager();
            

            universityManager.FemaleStudents();

        }

        public static void PrintOddNumbers(int[] numbers)
        {
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

            Console.WriteLine("Odd Numbers");
            foreach(int x in oddNumbers)
            {
                Console.WriteLine(x);
            }
        }

        public static void PrintEvenNumbers(int[] numbers)
        {
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 == 0 select number;

            Console.WriteLine("Even Numbers");
            foreach (int x in oddNumbers)
            {
                Console.WriteLine(x);
            }
        }


        
    }


    public class University
    {
        public int UniversityID { get; set; }
        public String UniversityName { get; set; }

        public void Display()
        {
            Console.WriteLine("University ID: {0} University Name: {1}", UniversityID, UniversityName);
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        //foreign key
        public int UniversityID { get; set; }

        public void Display()
        {
            Console.WriteLine("University ID: {0}", UniversityID);
            Console.WriteLine("Student ID: {0} Student Name: {1} Student Gender: {2} Student Age: {3}", StudentID, StudentName, Gender, Age);
        }
    }

    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { UniversityID = 1, UniversityName="GTU" });
            universities.Add(new University { UniversityID = 2, UniversityName = "DDU" });


            students.Add(new Student { StudentID = 1, StudentName = "Bhavik Vashi", Gender="Male" ,Age=22,UniversityID= 1});
            students.Add(new Student { StudentID = 2, StudentName = "Raj Patel", Gender = "Male", Age = 23, UniversityID = 1 });
            students.Add(new Student { StudentID = 3, StudentName = "Yash Patel", Gender = "Male", Age = 24, UniversityID = 1 });
            students.Add(new Student { StudentID = 4, StudentName = "Meet Patel", Gender = "Male", Age = 21, UniversityID = 2 });
            students.Add(new Student { StudentID = 5, StudentName = "Rakesh Patel", Gender = "Male", Age = 22, UniversityID = 2});
            students.Add(new Student { StudentID = 6, StudentName = "Palak Patel", Gender = "Female", Age = 23, UniversityID = 1 });
            students.Add(new Student { StudentID = 7, StudentName = "Misri Patel", Gender = "Female", Age = 21, UniversityID = 2 });
            students.Add(new Student { StudentID = 8, StudentName = "Rani Patel", Gender = "Female", Age = 24, UniversityID = 2 });

        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "Male" select student;
            Console.WriteLine("Male Students");
            foreach(Student s in maleStudents)
            {
                s.Display();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "Female" select student;
            Console.WriteLine("Female Students");
            foreach (Student s in femaleStudents)
            {
                s.Display();
            }
        }
    }
}
