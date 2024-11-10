namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            //int number = int.Parse(Console.ReadLine());
            //if (number >= 0 && number <= 100)
            //{
            //    if (number % 3 == 0 && number % 5 == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz");
            //    }
            //    else if (number % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (number % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Wrong number!");
            //}

            //Task2
            //float number = float.Parse(Console.ReadLine());
            //float percent = float.Parse(Console.ReadLine());

            //float result = (number * percent) / 100;
            //Console.WriteLine(result);

            //Task3
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());
            //int num4 = int.Parse(Console.ReadLine());
            //int result = 0;
            //int[] arr = new int[4];
            //arr[0] = num1;
            //arr[1] = num2;
            //arr[2] = num3;
            //arr[3] = num4;

            //for (int i = 0; i < 4; i++)
            //{
            //    result = result * 10 + arr[i];
            //}
            //Console.WriteLine(result);

            //Task4
            //int[] arr = new int[6];
            //int number = int.Parse(Console.ReadLine());
            //if (number >= 100000 && number <= 999999)
            //{
            //    while (number > 0)
            //    {
            //        for (int i = 0; i < arr.Length; i++)
            //        {
            //            arr[i] = number % 10;
            //            number = number / 10;
            //        }
            //    }
            //    Array.Reverse(arr);
            //    int index1 = int.Parse(Console.ReadLine()) - 1;
            //    int index2 = int.Parse(Console.ReadLine()) - 1;
            //    int tmp = arr[index1];
            //    arr[index1] = arr[index2];
            //    arr[index2] = tmp;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.Write(arr[i]);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error!");
            //}

            //Task6
            //float temperature = float.Parse(Console.ReadLine());
            //Console.WriteLine("1 to convert tempereture to Fahrenheit;\n2 to convert temperature to Celsius");
            //char user_choice = char.Parse(Console.ReadLine());
            //if (user_choice == '1')
            //{
            //    float result = (temperature * 9 / 5) + 32;
            //    Console.WriteLine(result);
            //}
            //else if (user_choice == 2)
            //{
            //    float result = (temperature - 32) * 5 / 9;
            //    Console.WriteLine(result);
            //}

            //Task7
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            if (min > max)
            {
                int tmp = min;
                min = max;
                max = tmp;
                for (int i = min; i <= max; i++)
                {
                    if(i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                for (int i = min; i <= max; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
