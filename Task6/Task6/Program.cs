using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {

        class Vehicle
        {
            protected string make;
            protected int year;
            protected string type;

            public Vehicle(string make, int year, string type)
            {
                this.make = make;
                this.year = year;
                this.type = type;
            }

            public virtual string GetVehicleInfo()
            {
                return $"Make: {make}, Year: {year}, Type: {type}";
            }
        }

        class Car : Vehicle
        {
            private decimal price;
            private string model;
            private string palletNo;
            private string color;
            private bool engineStarted;

            public Car(string make, int year, string type, decimal price, string model, string palletNo, string color)
                : base(make, year, type)
            {
                this.price = price;
                this.model = model;
                this.palletNo = palletNo;
                this.color = color;
                this.engineStarted = false; 
            }

            public void StartEngine()
            {
                if (!engineStarted)
                {
                    engineStarted = true;
                    Console.WriteLine("Engine started.");
                }
                else
                {
                    Console.WriteLine("Engine is already running.");
                }
            }

            public void StopEngine()
            {
                if (engineStarted)
                {
                    engineStarted = false;
                    Console.WriteLine("Engine stopped.");
                }
                else
                {
                    Console.WriteLine("Engine is already off.");
                }
            }

            public override string GetVehicleInfo()
            {
                return base.GetVehicleInfo() + $", Model: {model}, Price: {price}, Pallet No: {palletNo}, Color: {color}";
            }
        }

        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", 2020, "Sedan", 20000, "Camry", "ABC123", "Red");

            myCar.StartEngine();

            Console.WriteLine(myCar.GetVehicleInfo());

            myCar.StopEngine();
        }
    }
}
