using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class PolymorphismDemo
    {
    }

    public class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car()
        {

        }

        public Car(int hp,string color)
        {
            HP = hp;
            Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("HP: {0}\nColor: {1}", HP, Color);

        }

        public virtual void RepairCar()
        {
            Console.WriteLine("Car was repaired");
        }
    }

    public class Audi: Car
    {
        private string brand = "Audi";
        public string Model { get; set; }

        public Audi()
        {

        }

        public Audi(int hp,string color,string model) : base(hp, color)
        {
            Model = model;
        }
        public new void ShowDetails()
        {
            Console.WriteLine("Brand: {0} Model: {1} HP: {2} Color: {3}", brand, Model, HP, Color);
        }
        public override void RepairCar()
        {
            Console.WriteLine("{0} {1} was repaired",brand,Model);
        }
    }

    public class BMW: Car
    {
        private string brand = "BMW";
        public string Model { get; set; }

        public BMW()
        {

        }

        public BMW(int hp,string color,string model) : base(hp, color)
        {
            Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand: {0} Model: {1} HP: {2} Color: {3}", brand, Model, HP, Color);
        }

        public override void RepairCar()
        {
            Console.WriteLine("{0} {1} was repaired", brand, Model);
        }
    }
}
