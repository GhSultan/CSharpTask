using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {

        //1

        //class Human
        //{
        //    public string Firstname;
        //    public string Lastname;
        //    public int age;
        //}

        //class Student : Human
        //{
        //   public string StudentID;

        //}

        public sealed class Human
        {
            public void StartEngine()
            {
                Console.WriteLine("Engine started");
            }
        }

        //public class ElectricCar : Car 
        //{
        //}

        //................................................................

        //class Calculator
        //{
        //    public int Add(int a, int b)
        //    {
        //        return a + b;
        //    }

        //    public int Add(int a, int b, int c)
        //    {
        //        return a + b + c;
        //    }

        //    public double Add(double a, double b)
        //    {
        //        return a + b;
        //    }
        //}


        //class Animal
        //{
        //    public virtual void Speak()
        //    {
        //        Console.WriteLine("Animal makes a sound");
        //    }
        //}

        //class Dog : Animal
        //{
        //    public override void Speak()
        //    {
        //        Console.WriteLine("Dog barks");
        //    }
        //}

        //.............................................

        abstract class Animal
        {
            public abstract void MakeSound();

            public void Sleep()
            {
                Console.WriteLine("Animal is sleeping");
            }
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Dog barks");
            }
        }

        static void Main(string[] args)
        {
            //Student student = new Student();

            //student.Firstname = "Ghofran";
            //student.Lastname = "Sultan";
            //student.age = 22;
            //student.StudentID = "S12345";

            //Console.WriteLine($"Name: {student.Firstname} {student.Lastname}, Age: {student.age}, Student ID: {student.StudentID}");


            //...............................................
            //Calculator calculator = new Calculator();

            //Console.WriteLine(calculator.Add(1, 2));     //M1
            //Console.WriteLine(calculator.Add(1, 2, 3));  //M2
            //Console.WriteLine(calculator.Add(1.5, 2.3)); //M3



            //Animal myAnimal = new Animal();
            //myAnimal.Speak();  

            //Animal myDog = new Dog();
            //myDog.Speak();

            //...............................................


            Animal myDog = new Dog();
            myDog.MakeSound(); 
            myDog.Sleep();
        }
    }
}
