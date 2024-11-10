namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");
           
            //Task 2
            //int var1 = int.Parse(Console.ReadLine());
            //int var2 = int.Parse(Console.ReadLine());
            //int var3 = int.Parse(Console.ReadLine());
            //int var4 = int.Parse(Console.ReadLine());
            //int var5 = int.Parse(Console.ReadLine());
            //int result = var1 + var2 + var3 + var4 + var5;
            //int max = var1; int min = var1;
            //if (var2 > max)
            //{
            //    max = var2;
            //}
            //if (var3 > max)
            //{
            //    max = var3;
            //}
            //if(var4 > max)
            //{
            //    max = var4;
            //}
            //if(var5 > max)
            //{
            //    max = var5;
            //}

            //if (var2 < min)
            //{
            //    min = var2;
            //}
            //if (var3 < min)
            //{
            //    min = var3;
            //}
            //if (var4 < min)
            //{
            //    min = var4;
            //}
            //if(var5 < min)
            //{
            //    min = var5;
            //}
            //Console.WriteLine(result);
            //Console.WriteLine(max);
            //Console.WriteLine(min);


            //Task 3
            //int number = int.Parse(Console.ReadLine());
            //if (number >= 100000 && number <= 999999)
            //{
            //    int reverse = 0;
            //    while(number > 0)
            //    {
            //        reverse = reverse * 10 + number % 10;
            //        number /= 10;
            //    }
            //    Console.WriteLine(reverse);
            //}
            //else 
            //{
            //    Console.WriteLine("You put wrong number. Number must be 6 digit.");
            //}

            //Task 4
            //int min = int.Parse(Console.ReadLine());
            //int max = int.Parse(Console.ReadLine());

            //if (min < max)
            //{
            //    int f1 = 0;
            //    int f2 = 1;
            //    while (f1 < max)
            //    {
            //        if (f1 >= min)
            //        {
            //            Console.Write(f1);
            //            Console.Write(" ");
            //        }

            //        int next = f1 + f2;
            //        f1 = f2;
            //        f2 = next;

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Wrong diapason!");
            //}

            //Task 5
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());


            //if(A < B)
            //{
            //    for(int i = A;  i <= B; i++)
            //    {
            //        for(int j = 0; j < i; j++)
            //        {
            //            Console.Write(i);

            //        }
            //        Console.WriteLine(" ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error!");
            //}

            //Task 6
            char symbol = char.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            char go = char.Parse(Console.ReadLine());

            if (go == 'h')
            {
                for (int i = 0; i < lenght; i++)
                {
                    Console.Write(symbol); 
                }
            }
            else
            {
                for(int i = 0;i < lenght; i++)
                {
                    Console.WriteLine(symbol);
                }
            }
        }
    }
}