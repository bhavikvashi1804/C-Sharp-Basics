using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine("This is a {0}",Name);
        }

        public abstract double Volume();
    }

    public class Cube : Shape
    {
        public double Length { get; set; }

        public Cube(double length)
        {
            Name = "Cube";
            Length = length;
        }

        public override double Volume()
        {
            return (Length * Length * Length);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Cube Length: {0}",Length);

        }
    }
    public class Sphere : Shape
    {
        public double Raduis { get; set; }

        public Sphere(double r)
        {
            Name = "Sphere";
            Raduis = r;
        }
        public override double Volume()
        {
            double result = (4 / 3) *( Math.PI * Raduis * Raduis * Raduis);
            return result;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Sphere radius is: {0}", Raduis);

        }
    }
}
