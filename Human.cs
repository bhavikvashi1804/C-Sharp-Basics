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

        //constructor
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
            if (age == 1)
            {
                Console.WriteLine("Hi, I am {0} {1} and {2} year old. My eye color is {3}.", firstName, lastName, age, eyeColor);
            }
            else
            {
                Console.WriteLine("Hi, I am {0} {1} and {2} years old. My eye color is {3}.", firstName, lastName, age, eyeColor);

            }
        }

    }
}
