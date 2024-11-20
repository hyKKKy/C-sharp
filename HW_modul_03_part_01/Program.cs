using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HW_modul_03_part_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HomeWork s1 = new HomeWork();
            //s1.Draw(4, '*');

            //HomeWork s1 = new HomeWork();
            //Console.WriteLine(s1.Cheker(123321));

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] arr2 = { 1, 3, 6, 7, 4, 10 };

            //int[] result = s1.Filter(arr, arr2);
            //Console.WriteLine(string.Join(" ", result));

            WebSite site = new WebSite();
            site.Name = "Hello1";
            site.Url = "https://hello1";
            site.description = "Description";
            site.ip = "127.0.0.1";

            //Console.WriteLine($"Name: {site.Name}");
            //Console.WriteLine($"URL: {site.Url}");
            //Console.WriteLine($"Description: {site.description}");
            //Console.WriteLine($"IP: {site.ip}");

            Journal journal = new Journal();
            journal.name = "Name";
            journal.description = "Description";
            journal.email = "email@email";
            journal.established = 1978;
            journal.number = "+12598723";

            //Console.WriteLine($"Name: {journal.name}");
            //Console.WriteLine($"Description: {journal.description}");
            //Console.WriteLine($"email: {journal.email}");
            //Console.WriteLine($"established: {journal.established}");
            //Console.WriteLine($"number: {journal.number}");

            Shop shop = new Shop();
            shop.name = "Shop";
            shop.number = "+9128419056";
            shop.description = "Description";
            shop.email = "email@email";
            shop.address = "St. qwerty123";

            //Console.WriteLine($"Name: {shop.name}");
            //Console.WriteLine($"number: {shop.number}");
            //Console.WriteLine($"description: {shop.description}");
            //Console.WriteLine($"email: {shop.email}");
            //Console.WriteLine($"address: {shop.address}");
        }

        //Task 1
        class HomeWork
        {
            public void Draw(int a, char c)
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        Console.Write(c);
                    }
                    Console.WriteLine();
                }
            }
            public bool Cheker(int number)
            {
                string str = number.ToString();
                int left = 0;
                int right = str.Length - 1;

                while (left < right)
                {
                    while (left < right && !char.IsLetterOrDigit(str[left])) left++;
                    while (left < right && !char.IsLetterOrDigit(str[right])) right--;

                    if (char.ToLower(str[left]) != char.ToLower(str[right]))
                        return false;

                    left++;
                    right--;
                }

                return true;
            }

            public int[] Filter(int[] original_arr, int[] param_arr)
            {
                return original_arr.Where(x => !param_arr.Contains(x)).ToArray();
            }
        }

        class WebSite 
        { 
            public string Name { get; set; }
            public string Url { get; set; }
            public string description { get; set; }
            public string ip { get; set; }

        }

        class Journal
        {
            public string name { get; set; }
            public int established { get; set; }
            public string description { get; set; }
            public string number { get; set; }
            public string email {get; set; }
        }

        class Shop
        { 
            public string name { get; set; }
            public string address { get; set; }
            public string description { get; set; }
            public string number { get; set; }
            public string email { get; set; }
        }



    }
}
