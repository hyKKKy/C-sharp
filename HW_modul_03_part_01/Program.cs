using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
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

            HomeWork s1 = new HomeWork();
            Console.WriteLine(s1.Cheker(123321));

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = { 1, 3, 6, 7, 4, 10 };

            int[] result = s1.filter(arr, arr2);
            Console.WriteLine(string.Join(" ", result));

            WebSite site = new WebSite();
            site.Name = "Hello1";
            site.Url = "https://hello1";
            site.description = "Description";
            site.ip = "127.0.0.1";

            site.print();

            Journal journal = new Journal();
            journal.name = "Name";
            journal.description = "Description";
            journal.email = "email@email";
            journal.established = 1978;
            journal.number = "+12598723";

            journal.print();

            Shop shop = new Shop();
            shop.name = "Shop";
            shop.number = "+9128419056";
            shop.description = "Description";
            shop.email = "email@email";
            shop.address = "St. qwerty123";

            shop.print();
            
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

            public int[] filter(int[] original_arr, int[] for_filter)
            {
                int[] tmp = new int[original_arr.Length];
                int index = 0;

                foreach (int i in original_arr)
                {
                    bool Flag = false;

                    foreach (int j in for_filter)
                    {
                        if (i == j)
                        {
                            Flag = true;
                            break;
                        }
                    }

                    if (Flag != true)
                    {
                        tmp[index++] = i;
                    }
                }

                int[] result = new int[index];
                Array.Copy(tmp, result, index);
                return result;
            }
        }

        class WebSite 
        { 
            public string Name { get; set; }
            public string Url { get; set; }
            public string description { get; set; }
            public string ip { get; set; }

            public void print()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"URL: {Url}");
                Console.WriteLine($"Description: {description}");
                Console.WriteLine($"IP: {ip} \n");
            }

        }

        class Journal
        {
            public string name { get; set; }
            public int established { get; set; }
            public string description { get; set; }
            public string number { get; set; }
            public string email {get; set; }

            public void print()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Description: {description}");
                Console.WriteLine($"email: {email}");
                Console.WriteLine($"established: {established}");
                Console.WriteLine($"number: {number}\n");
            }
        }

        class Shop
        { 
            public string name { get; set; }
            public string address { get; set; }
            public string description { get; set; }
            public string number { get; set; }
            public string email { get; set; }

            public void print()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"number: {number}");
                Console.WriteLine($"description: {description}");
                Console.WriteLine($"email: {email}");
                Console.WriteLine($"address: {address}\n");
            }
        }



    }
}
