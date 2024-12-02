﻿namespace C__HW_modul_03_part_02_ua
{
    internal class Program
    {
        delegate int[] SortNumbers(int[] arr);

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 13, 21     };
            //SortNumbers sn1;
            //sn1 = EvenNumbers;
            //int[] evenNumbers = sn1(arr);

            //Console.WriteLine("Even: " + string.Join(", ", evenNumbers));

            //SortNumbers sn2;
            //sn2 = OddNumbers;
            //int[] oddNumbers = sn2(arr);

            //Console.WriteLine("Odd: " + string.Join(", ", oddNumbers));

            //SortNumbers sn3;
            //sn3 = PrimeNumbers;
            //int[] prime = sn3(arr);

            //Console.WriteLine("Prime: " + string.Join(", ", prime));

            //SortNumbers sn4;
            //sn4 = FibonacciNumbers;
            //int[] fibonacci = sn4(arr);

            //Console.WriteLine("Fibonacci: " + string.Join(", ", fibonacci));

            DateTime dateTime = DateTime.Now;
            Action<string> printTime = message => Console.WriteLine(message);
            printTime($"Time is: {dateTime:HH:mm:ss}");

            Action<string> printDate = message => Console.WriteLine(message);
            printDate($"Date is: {dateTime:yyyy:MM:d}");

            Action<string> printDayOfWeek = message => Console.WriteLine(message);
            printDayOfWeek($"Day of the week is: {dateTime:dddd}");

            Func<double, double, double> triangle = (baseT, height) => baseT * 0.5 * height;
            Console.WriteLine($"Triangle with base = 5sm and height = 4sm = {triangle(5, 4)}");

            Func<double, double, double> rectangle = (width, height) => width * height;
            Console.WriteLine($"Rectangle with width 5sm and height 10sm = {rectangle(5, 10)}");
        }

        public static int[] EvenNumbers(int[] arr) 
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    counter++;
                }
            }
            int[] result = new int[counter];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    result[index] = arr[i];
                    index++;
                }
            }
            return result;
        }

        public static int[] OddNumbers(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    counter++;
                }
            }
            int[] result = new int[counter];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    result[index] = arr[i];
                    index++;
                }
            }
            return result;
        }

        public static int[] PrimeNumbers(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                {
                    counter++;
                }
            }

            int[] result = new int[counter];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                {
                    result[index] = arr[i];
                    index++;
                }
            }

            return result;
        }

        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static int[] FibonacciNumbers(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsFibonacci(arr[i]))
                {
                    counter++;
                }
            }

            int[] result = new int[counter];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsFibonacci(arr[i]))
                {
                    result[index] = arr[i];
                    index++;
                }
            }

            return result;
        }

        public static bool IsFibonacci(int number)
        {
            if (number < 0) return false;
            
            long x1 = 5L * number * number + 4;
            long x2 = 5L * number * number - 4;

            return IsSquare(x1) || IsSquare(x2);
        }

        public static bool IsSquare(long number)
        {
            long sqrt = (long)Math.Sqrt(number);
            return sqrt * sqrt == number;
        }
    }
}
