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
            this.length = length;
            this.width = width;
            this.height = height;
        }

        //setter and getter
        public void SetLength(int length)
        {
            if( length < 0)
            {
                throw new Exception("Length must be greater than 0");
            }
            this.length = length;
        }
        public int GetLength()
        {
            return length;
        }
        public void SetWidth(int width)
        {
            if(width < 0)
            {
                throw new Exception("width must be greater than 0");
            }
            this.width = width;
        }
        public int GetWidth()
        {
            return width;
        }
        public void SetHeight(int height)
        {
            if (height < 0)
            {
                throw new Exception("Height must be greater than 0");
            }
            this.height = height;
        }
        public int GetHeight()
        {
            return height;
        }
        public int GetVolume()
        {
            calculateVolume();
            return volume;
        }


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
