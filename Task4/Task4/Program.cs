using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {


        static void CalculateSumAndAverage()
        {
            //1

            int sum = 0;
            double average = 0.0;
            Console.WriteLine("To calculate the sum and the average enter 10 number");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}.Enter the number now : ");
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }
            average += (double)sum / 10;

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
        }

            //2
            
        static int cubeNumber(int number)
        {
            int result = 1;
            for (int i = 0; i < 3; i++)
            {
                result *= number ;
            }

            return result;
        }

        //3
        static int[] getYears(int[] years)
        {
            int count = 0;
            for (int i = 0; i < years.Length; i++)
            {
                if (years[i] > 1950)
                {
                    count++;
                }
            }

            int[] newArr = new int[count];
            int index = 0;

            for (int i = 0; i < years.Length; i++)
            {
                if (years[i] > 1950)
                {
                    newArr[index] = years[i];
                    index++;
                }
            }

            return newArr; 
        }

        //4
        static void culcAge()
        {
            Console.WriteLine("Enter your birth date : ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            DateTime currentDate = DateTime.Now;

            TimeSpan ageSpan = currentDate - birthDate;

            int ageInDays = (int)ageSpan.TotalDays;

            Console.WriteLine($"Your age in days: {ageInDays}");
        

    }

        //5
        static int Animals(int chickens, int cows, int pigs)
        {
            int totalLegs = (chickens * 2) + (cows * 4) + (pigs * 4);
            return totalLegs;
        }

        //6
        static double CalculatePower(double number, int power)
        {
            if (power == 0)
            {
                return 1; 
            }

            double result = number;
            for (int i = 1; i < power; i++)
            {
                result *= number; 
            }

            return result;
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true; 
        }


        static void Main(string[] args)
        {
            //CalculateSumAndAverage();

            //Console.WriteLine(cubeNumber(4));       

            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            int[] result = getYears(years);
            //Console.WriteLine("Years greater than 1950: [" + string.Join(", ", result) + "]");

            //culcAge();

            //Console.WriteLine(Animals(2, 4, 6));

            //Console.WriteLine(CalculatePower(2, 4));

            Console.WriteLine("Enter a number to check if it is prime:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }

    }
}
