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


        //has a RelationShip
        protected CarIDInfo carIDInfo= new CarIDInfo();

        public void SetCarIDInfo(int id,string owner)
        {
            carIDInfo.ID = id;
            carIDInfo.Owner = owner;
        }
        public void GetCarIDInfo()
        {
            Console.WriteLine("Car ID: {0}, Car Owner: {1}", carIDInfo.ID, carIDInfo.Owner);
        }

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

        public sealed override void RepairCar()
        {
            Console.WriteLine("{0} {1} was repaired", brand, Model);
        }
    }

    public class M3: BMW
    {
        public M3(int hp,string color,string model) : base(hp, color, model)
        {
        }



        //sealed method is not allowed to be override 
        /*
        public override void RepairCar()
        {
            base.RepairCar();
        }
        */

        //You can also mark class as sealed so it can not be take part in inheritance
    }

    //HAS-A
    public class CarIDInfo
    {
        public int ID { get; set; }
        public string Owner { get; set; } = "No owner";

    }
}
