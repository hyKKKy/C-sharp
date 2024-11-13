namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            //int size = 10;

            //int[] arr = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int evenCounter = 0;
            //int oddCounter = 0;

            //for (int i = 0;i < size; i++)
            //{
            //    if(arr[i] % 2 == 0)
            //    {
            //        evenCounter++;
            //    }
            //    else if (arr[i] % 2 != 0)
            //    {
            //        oddCounter++;
            //    }
            //}

            //Console.WriteLine("even: {0}", evenCounter);
            //Console.WriteLine("odd: {0}", oddCounter);

            //task 2

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            //int user_number = int.Parse(Console.ReadLine());

            //for(int i = 0;i < arr.Length; i++)
            //{
            //    if(arr[i] < user_number)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}

            //task 3
            //char[] arr = new char[100];

            //string user_input = Console.ReadLine();

            //arr = user_input.ToCharArray();

            //int vowelCounter = 0;

            //foreach (char c in arr)
            //{
            //    if("aeoei".IndexOf(c) >= 0)
            //    {
            //        vowelCounter++;
            //    }
            //}

            //Console.WriteLine(vowelCounter);

            //task4
            string line = Console.ReadLine();

            string[] wordsArr = line.Split(' ');

            for (int i = 0; i < wordsArr.Length; i++)
            {
                char[] words = wordsArr[i].ToCharArray();
                Array.Reverse(words);
                wordsArr[i] = new string(words);
            }
            for (int i = 0; i < wordsArr.Length; i++)
            {
                Console.WriteLine(wordsArr[i]);
            }

        }
    }
}
