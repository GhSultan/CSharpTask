using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTasks
{
    internal class Program
    {
        //  Task Functions 1:

        //1
        static int converts(int minutes)
        {
            return (minutes * 60);
        }

        //2
        static int incrementsNumber(int number)
        {
            return (number + 1);
        }

        //3
        static int arrfunction(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

            }

            return arr[0];
        }

        //4
        static double areaTriangle(double baseLength, double height)
        {
            return (0.5 * baseLength * height);
        }

        //5
        //static int[] evenNumberEvenIndex(int[] evenArr)
        //{
        //    int count = 0;
        //    for (int i = 0; i < evenArr.Length; i++)
        //    {
        //        if (evenArr[i] % 2 == 0 && i % 2 == 0)
        //        {
        //            count++; 
        //        }
        //    }

        //    int[] newArr = new int[count];
        //    int index = 0;

        //    for (int i = 0; i < evenArr.Length; i++)
        //    {
        //        if (evenArr[i] % 2 == 0 && i % 2 == 0)
        //        {
        //            newArr[index] = evenArr[i]; 
        //            index++; 
        //        }
        //    }

        //    return newArr; 
        //}


        //6

        static string[] evenIndexOddLength(string[] strArr)
        {
            int count = 0;
            for (int i = 0; i < strArr.Length; i++)
            {
                if (i % 2 == 0 && strArr[i].Length % 2 != 0)
                {
                    count++;
                }
            }

            string[] newArr = new string[count];
            int index = 0;

            for (int i = 0; i < strArr.Length; i++)
            {
                if (i % 2 == 0 && strArr[i].Length % 2 != 0)
                {
                    newArr[index] = strArr[i];
                    index++;
                }
            }

            return newArr;
        }


        //7
        static int[] powerElementIndex(int[] powerArr)
        {
            int count = 0;
            for (int i = 0; i <powerArr.Length; i++)
            {
                count++;

            }
            int[] newArr = new int[count];

            for (int i = 0; i < powerArr.Length; i++)
            {
                newArr[i] = (int)Math.Pow(powerArr[i], i);
            }
            return newArr;
        }

        //8
        static int multiplication2(int num1, int num2)
        {
            int resultNum = 0;

            for (int i = 0; i < num2; i++)
            {
                resultNum = resultNum + num1;
            }
            return resultNum;
        }

        //9
        static int muti2(int num1, int num2)
        {
            int result = 1;
            for (int i = num1; i <= num2; i++)
            {
                result = result * i ; 
            }
            return result;
        }

        //10
        static double aveArray(int[] nums)
        {
            double sum = 0; 

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            double average = sum / nums.Length;

            return average; 
        }

        //Task function (2)
        //1
        static int dateFunction(DateTime startDay, DateTime endDay)
        {            
            TimeSpan difference = endDay - startDay;

            return (int)difference.TotalDays;
        }

        //2


        //3

        static string ReverseOdd(string input)
        {
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    char[] charArray = words[i].ToCharArray(); 
                    Array.Reverse(charArray); 
                    words[i] = new string(charArray); 
                }
            }

            return string.Join(" ", words);
        }

        //4
        static bool IsPandigital(long number)
        {
            bool[] digits = new bool[10];

            string numString = number.ToString();

            foreach (char digit in numString)
            {
                if (char.IsDigit(digit)) 
                {
                    digits[digit - '0'] = true; 
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (!digits[i]) 
                {
                    return false;
                }
            }

            return true; 
        }


        static void Main(string[] args)
        {
            //Console.WriteLine("Converts minutes to Second :"+converts(4));

            //Console.WriteLine("increment number :"+incrementsNumber(3));


            int[] array = { 9, 2, 3, 4 };
            //Console.WriteLine("First elemaint of array :" + arrfunction(array));


            //Console.WriteLine("Area Triangle :" + areaTriangle(3, 5));


            //int[] arr = { 1, 3, 2, 4 ,10 ,9 ,8 };
            //int[] evenNumbersAtEvenIndex = evenNumberEvenIndex(arr);
            //Console.WriteLine( string.Join(", ", evenNumbersAtEvenIndex));

            string[] strings = { "hello", "ghofran", "sultan"};
            //string[] result = evenIndexOddLength(strings);
            //Console.WriteLine(string.Join(", ", result));

            int[] intarr = { 44, 5, 4, 3, 2, 10 };
            int[] result = powerElementIndex(intarr);
            //Console.WriteLine(string.Join(", ", result));

            //Console.WriteLine(multiplication2(2, 3));

            //Console.WriteLine(muti2(1,4));

            var nums = new int[] { 1, 5, 2, 3, 0 };
            //Console.WriteLine(aveArray(nums));

            //Console.WriteLine(dateFunction(2, 5));


            DateTime date1 = new DateTime(2019, 6, 14);
            DateTime date2 = new DateTime(2019, 6, 20);
            //Console.WriteLine(dateFunction(date1, date2));


            Console.WriteLine(ReverseOdd("Bananas")); 
            Console.WriteLine(ReverseOdd("One two three four"));

            Console.WriteLine(IsPandigital(98140723568910)); 
            Console.WriteLine(IsPandigital(90864523148909));
            Console.WriteLine(IsPandigital(112233445566778899));

        }
    }
}
