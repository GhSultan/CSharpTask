using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        //1
        class MyClass
        {
            public MyClass()
            {
                Console.WriteLine("MyClass class has initialized!");

            }
        }

        //2
        class Message
        {
            public void DisplayMessage(string name)
            {
                Console.WriteLine($"Hello All, I am {name}");
            }
        }


        //3
        class FactorialCalculator
        {
            public int CalculateFactorial(int num)
            {
                int result = 1;
                for (int i = 1; i < num; i++)
                {
                    result *= i;
                }
                return result;
            }
        }

        //4
        class ArraySorter
        {
            public void SortArray(int[] array)
            {
                Array.Sort(array);

                Console.Write("Sorted array: { ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                        Console.Write(", ");
                }
                Console.WriteLine(" }");
            }
        }

        //5
        class DateDifferenceCalculator
        {
            public void CalculateDateDifference(DateTime date1, DateTime date2)
            {
                TimeSpan difference = date2 - date1;

                int years = (int)(difference.TotalDays / 365.25);
                DateTime tempDate = date1.AddYears(years);

                int months = tempDate.Month > date2.Month ? 0 : date2.Month - tempDate.Month;
                if (months < 0)
                {
                    months += 12;
                }

                int days = (date2 - tempDate.AddMonths(months)).Days;

                Console.WriteLine($"Difference: {years} years, {months} months, {days} days.");
            }
        }


        static void Main(string[] args)
        {

            MyClass obj1 = new MyClass();

            Message obj2 = new Message();
            obj2.DisplayMessage("Ghofran");



            FactorialCalculator obj3 = new FactorialCalculator();
            Console.WriteLine("Enter an integer to calculate its factorial:");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = obj3.CalculateFactorial(num);
            Console.WriteLine($"The factorial of {num} is: {factorial}");


            int[] array = { 11, -2, 4, 35, 0, 8, -9 };

            ArraySorter obj4 = new ArraySorter();
            obj4.SortArray(array);


            DateTime date1 = new DateTime(1981, 11, 03);
            DateTime date2 = new DateTime(2013, 09, 04);

            DateDifferenceCalculator calculator = new DateDifferenceCalculator();

            calculator.CalculateDateDifference(date1, date2);



            //6

            string dateString = "12-08-2004";

            DateTime date = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);

            string formattedDate = date.ToString("yyyy-MM-dd");
            Console.WriteLine($"Converted Date: {formattedDate}");

        }
    }
}
