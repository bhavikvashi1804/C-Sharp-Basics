using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class Box
    {
        //member variables
        private int length, width, height,volume;

        public Box(int length,int width,int height)
        {
            Length = length;
            Width = width;
            Height = height;
            //it is also okay to use this.length = length at here
        }

        //setter and getter
        public int Length
        {
            set
            {
                if(value < 0)
                {
                    throw new Exception("Length must be greater than 0");  
                }
                this.length = value;
            }
            get
            {
                return length;
            }
        }

        public int Width
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Width must be greater than 0");
                }
                this.width = value;
            }
            get
            {
                return width;
            }
        }

        public int Height
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Height must be greater than 0");
                }
                this.height = value;
            }
            get
            {
                return height;
            }
        }


        public int Volume
        {
            get
            {
                calculateVolume();
                return volume;
            }
        }

        public string BoxName { get; set; }





        //methods
        public void DisplayInfo()
        {
            calculateVolume();
            Console.WriteLine("Box: Length:{0}, Width:{1}, Height:{2}, Volume:{3}",length,width,height,volume);
        }

        public void calculateVolume()
        {
            volume = length * width * height;
        }
    }
}
