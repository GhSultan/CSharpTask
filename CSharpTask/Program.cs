using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Enter the your name :");
            string name = Console.ReadLine();
            Console.WriteLine($"Your name is {name} !");

            //2
            int number = 2;
            string text = "ghofran";
            double number2 = 22.4;
            float number3 = 234.56f;
            char letter = 'e';
            bool num = true;

            Console.WriteLine(number);
            Console.WriteLine(text);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(letter);
            Console.WriteLine(num);

            //3

            string[] cars = { "car1", "car2", "car3" };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);

            }

            //4
            Console.WriteLine("Enter your firstName :");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your lastName :");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your year of birth :");
            int birth = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Your name is {firstName} {lastName} {birth}!");


            //5
            int[] arr = new int[10];

            Console.WriteLine("Input 10 elements in the array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"element - {i} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nElements in array are:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            //6
            int[] arr2 = new int[3];
            int sum = 0;

            Console.WriteLine("Input 3 elements in the array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"index - {i} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine($"Sum of all elements stored in the array is : {sum}");


        }
    }
}
