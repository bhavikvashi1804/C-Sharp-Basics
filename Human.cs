using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    //class is blueprint of datatype 
    class Human
    {
        //member variable
        string firstName, lastName;
        //to access member variable you have to make it public
        //if you do not make it public then you can only use it in this class
        public string fullName="Human Name";
        //provide default value: fullName to Human name 


        //methods
        public void IntroduceMySelf()
        {
            Console.WriteLine("Hi, I am {0}", fullName);
        }

    }
}
