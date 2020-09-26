using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace C_Sharp
{
    class LinqDemo
    {

        public static void LinqDemo1()
        {
            XMLAndLINQ();


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


        public static void XMLAndLINQ()
        {
            string studentsXML =
                        @"<Students>
                            <Student>
                                <Name>Toni</Name>
                                <Age>21</Age>
                                <University>Yale</University>
                                <Semester>6</Semester>
                            </Student>
                            <Student>
                                <Name>Carla</Name>
                                <Age>17</Age>
                                <University>Yale</University>
                                <Semester>1</Semester>
                            </Student>
                            <Student>
                                <Name>Leyla</Name>
                                <Age>19</Age>
                                <University>Beijing Tech</University>
                                <Semester>3</Semester>
                            </Student>
                            <Student>
                                <Name>Frank</Name>
                                <Age>25</Age>
                                <University>Beijing Tech</University>
                                <Semester>10</Semester>
                            </Student>
                        </Students>";


            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);


            //Decendants will accept the class Name (Student which is common in all not students
            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value
                           };

            foreach (var student in students)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} is in his/her {3} Semester", student.Name, student.Age, student.University, student.Semester);
            }


            Console.WriteLine("Sort the students by age");

            var sortedStudents = from student in students
                                 orderby student.Age
                                 select student;
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} is in his/her {3} Semester", student.Name, student.Age, student.University, student.Semester);
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

        public void SortStudentByAge()
        {
            IEnumerable<Student> students1 = from student in students orderby student.Age select student;
            Console.WriteLine("Sort According to Age");
            foreach (Student s in students1)
            {
                s.Display();
            }
        }

        public void AllStudentsFromGTU()
        {
            IEnumerable<Student> gtuStudents = from student in students
                                               join university in universities
                                               on student.UniversityID equals university.UniversityID
                                               where university.UniversityName == "GTU"
                                               select student;
            Console.WriteLine("GTU Students");
            foreach (Student s in gtuStudents)
            {
                s.Display();
            }
        }


        public void GetTheStudentByUniversityName(string universityName)
        {
            IEnumerable<Student> gtuStudents = from student in students
                                               join university in universities
                                               on student.UniversityID equals university.UniversityID
                                               where university.UniversityName == universityName
                                               select student;
            Console.WriteLine("{0} Students",universityName);
            foreach (Student s in gtuStudents)
            {
                s.Display();
            }
        }


        public void StudentAndUniversityCollecton()
        {
            var newCollection = from student in students
                                join university in universities
                                on student.UniversityID equals university.UniversityID
                                orderby student.StudentName
                                select new { StudentName = student.StudentName, UniversityName = university.UniversityName};

            foreach(var item in newCollection)
            {
                Console.WriteLine("Student Name: {0}\t University Name: {1}", item.StudentName, item.UniversityName);
            }
        }
    }
}
