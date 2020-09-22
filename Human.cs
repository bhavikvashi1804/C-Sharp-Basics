using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace C_Sharp
{
    //class is blueprint of datatype 
    class Human
    {
        //member variable
        private string firstName, lastName,eyeColor;
        private int age;

        //default constructor
        public Human()
        {
            Console.WriteLine("Default Constructor is called");
        }

        //copy constructor
        public Human(Human h1)
        {
            this.firstName = h1.firstName;
            this.lastName = h1.lastName;
            this.eyeColor = h1.eyeColor;
            this.age = h1.age;
        }

        //parameterized constructor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Human(string firstName,string lastName,string eyeColor,int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        //methods
        public void IntroduceMySelf()
        {
            if(age != 0)
            {
                if (age == 1)
                {
                    Console.WriteLine("Hi, I am {0} {1} and {2} year old. My eye color is {3}.", firstName, lastName, age, eyeColor);
                }
                else
                {
                    Console.WriteLine("Hi, I am {0} {1} and {2} years old. My eye color is {3}.", firstName, lastName, age, eyeColor);

                }
            }
            else
            {
                Console.WriteLine("Hi, I am {0} {1}", firstName, lastName);
            }
           
        }

    }
}
