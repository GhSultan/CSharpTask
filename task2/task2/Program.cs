using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    internal static class Program
    {

        static void Main()
        {
            //1...................................................

            //Console.Write("Enter two number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());


            //if (num1 < num2)
            //{
            //    Console.WriteLine(num1);
            //}
            //else if (num2 < num1)
            //{
            //    Console.WriteLine(num2);
            //}
            //else
            //{
            //    Console.WriteLine("Number one = number two ");

            //}


            //2................................................


            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number > 0)
            //{
            //    Console.WriteLine("The sign is: +");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine("The sign is: -");
            //}
            //else
            //{
            //    Console.WriteLine("The sign is: 0");
            //}



            //3..............................................

            //Console.Write("Enter the first number: ");
            //int number1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the third number: ");
            //int number3 = Convert.ToInt32(Console.ReadLine());

            //int first, second, third;

            //if (number1 <= number2 && number1 <= number3)
            //{
            //    first = number1;
            //    if (number2 <= number3)
            //    {
            //        second = number2;
            //        third = number3;
            //    }
            //    else
            //    {
            //        second = number3;
            //        third = number2;
            //    }
            //}
            //else if (number2 <= number1 && number2 <= number3)
            //{
            //    first = number2;
            //    if (number1 <= number3)
            //    {
            //        second = number1;
            //        third = number3;
            //    }
            //    else
            //    {
            //        second = number3;
            //        third = number1;
            //    }
            //}
            //else
            //{
            //    first = number3;
            //    if (number1 <= number2)
            //    {
            //        second = number1;
            //        third = number2;
            //    }
            //    else
            //    {
            //        second = number2;
            //        third = number1;
            //    }
            //}

            //Console.WriteLine($"Sorted numbers in ascending order: {first}, {second}, {third}");


            //4.............................................


            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fifth number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());

            int max = num1;

            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }
            if (num4 > max)
            {
                max = num4;
            }
            if (num5 > max)
            {
                max = num5;
            }

            Console.WriteLine("The maximum number is: " + max);


            //5...................................................

            Console.Write("Input kilometers per hour: ");
            double kilometersPerHour = Convert.ToDouble(Console.ReadLine());

            // Conversion factor from kilometers to miles
            double conversionFactor = 0.621371;

            // Convert kilometers per hour to miles per hour
            double milesPerHour = kilometersPerHour * conversionFactor;

            // Display the result
            Console.WriteLine($"{kilometersPerHour} kilometers per hour is {milesPerHour} miles per hour.");


            //6............................................................
            Console.Write("Input hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int totalMinutes = (hours * 60) + minutes;

            Console.WriteLine($"Total: {totalMinutes} minutes.");



            //7...................................................

            Console.Write("Input minutes: ");
            int totalInputMinutes = Convert.ToInt32(Console.ReadLine());

            int totalHours = totalInputMinutes / 60;
            int remainingMinutes = totalInputMinutes % 60;

            Console.WriteLine($"{totalHours} Hours, {remainingMinutes} Minutes");


            //8....................................................
            string[] sentences = new string[5]
            {
                "Learning C# is fun!",
                "Arrays store multiple values.",
                "Programming is a valuable skill.",
                "This is a simple example.",
                "Short sentence."
            };

            int fixedLength = 25;

            foreach (string sentence in sentences)
            {

                string formattedSentence = sentence.Length < fixedLength
                    ? sentence.PadRight(fixedLength)
                    : sentence.Substring(0, fixedLength);

                Console.WriteLine(formattedSentence);
            }


            //...............Task3.................

            //1


            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

            Console.WriteLine(string.Join(", ", ARR));
            Console.WriteLine(string.Join(", ", arr2));
            Console.WriteLine(string.Join(", ", arr3));



            //2
            string[] fruits = { "Tomato", "Banana", "Watermelon" };

            int bananaIndex = Array.IndexOf(fruits, "Banana");

            int tomatoIndex = Array.IndexOf(fruits, "Tomato");


            Console.WriteLine($"index 'Banana': {bananaIndex}");
            Console.WriteLine($"index 'Tomato': {tomatoIndex}");

            //3

            string[] favoriteFood = { "Pizza", "Sushi", "Pasta", "Burgers", "Salad" };
            string[] favoriteSport = { "Football", "Basketball", "Tennis" };
            string[] favoriteMovie = { "Inception", "The Dark Knight", "Interstellar", "Forrest Gump" };

            Console.WriteLine("Favorite Food:");
            foreach (var food in favoriteFood)
            {
                Console.WriteLine(food);
            }

            Console.WriteLine("\nFavorite Sport:");
            foreach (var sport in favoriteSport)
            {
                Console.WriteLine(sport);
            }

            Console.WriteLine("\nFavorite Movie:");
            foreach (var movie in favoriteMovie)
            {
                Console.WriteLine(movie);
            }

            Console.WriteLine("\nPrinting Favorite Food using for loop:");
            for (int i = 0; i < favoriteFood.Length; i++)
            {
                Console.WriteLine(favoriteFood[i]);
            }

            Console.WriteLine("\nPrinting Favorite Sport using for loop:");
            for (int i = 0; i < favoriteSport.Length; i++)
            {
                Console.WriteLine(favoriteSport[i]);
            }

            Console.WriteLine("\nPrinting Favorite Movie using for loop:");
            for (int i = 0; i < favoriteMovie.Length; i++)
            {
                Console.WriteLine(favoriteMovie[i]);
            }

            //4
            string[] preferredFood = { "Pizza", "Sushi", "Pasta", "Burgers", "Salad" };
            string[] preferredSports = { "Football", "Basketball", "Tennis" };
            string[] preferredMovies = { "Inception", "The Dark Knight", "Interstellar", "Forrest Gump" };

            Console.WriteLine("Preferred Food:");
            foreach (var food in preferredFood)
            {
                Console.WriteLine(food);
            }

            Console.WriteLine("\nPreferred Sports:");
            foreach (var sport in preferredSports)
            {
                Console.WriteLine(sport);
            }

            Console.WriteLine("\nPreferred Movies:");
            foreach (var movie in preferredMovies)
            {
                Console.WriteLine(movie);
            }

            Console.WriteLine("\nPrinting Preferred Food using for loop:");
            for (int index = 0; index < preferredFood.Length; index++)
            {
                Console.WriteLine(preferredFood[index]);
            }

            Console.WriteLine("\nPrinting Preferred Sports using for loop:");
            for (int index = 0; index < preferredSports.Length; index++)
            {
                Console.WriteLine(preferredSports[index]);
            }

            Console.WriteLine("\nPrinting Preferred Movies using for loop:");
            for (int index = 0; index < preferredMovies.Length; index++)
            {
                Console.WriteLine(preferredMovies[index]);
            }

            //5
            Console.Write("Input three numbers separated by comma: ");
            string userInput = Console.ReadLine();

            string[] numberStrings = userInput.Split(',');

            int firstNumber = int.Parse(numberStrings[0].Trim());
            int secondNumber = int.Parse(numberStrings[1].Trim());
            int thirdNumber = int.Parse(numberStrings[2].Trim());

            int totalSum = firstNumber + secondNumber + thirdNumber;

            Console.WriteLine($"The sum of three numbers: {totalSum}.");

            //6
            int sumOfOddNumbers = 0;

            Console.WriteLine("The odd numbers are:");

            for (int number = 1; number <= 100; number++)
            {
                if (number % 2 != 0)
                {
                    Console.Write(number + " ");
                    sumOfOddNumbers += number;
                }
            }

            Console.WriteLine("\nThe Sum of odd Numbers is: " + sumOfOddNumbers);


            //7

            int oddNumbersSum = 0;

            Console.WriteLine("The odd numbers are:");

            for (int currentNumber1 = 1; currentNumber1 <= 100; currentNumber1++)
            {
                if (currentNumber1 % 2 != 0)
                {
                    Console.Write(currentNumber1 + " "); 
                    oddNumbersSum += currentNumber1;     
                }
            }

            Console.WriteLine("\nThe Sum of odd Numbers is: " + oddNumbersSum);

            //8

            int height = 3; 

            for (int i = 1; i <= height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            int triangleHeight = 4; 
            int currentNumber = 1;   

            for (int row = 1; row <= triangleHeight; row++)
            {
                for (int space = triangleHeight; space > row; space--)
                {
                    Console.Write(" ");
                }

                for (int count = 1; count <= row; count++)
                {
                    Console.Write(currentNumber + " ");
                    currentNumber++; 
                }

               
                Console.WriteLine();
            }



        }
    }
}