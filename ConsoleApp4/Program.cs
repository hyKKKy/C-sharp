using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = Capital(s);
            Console.WriteLine(result);
        }

        static string Arithmetic(string user_str)
        {
        }

        static string Capital(string user_str)
        {
            bool isCap = true;
            char[] chars = user_str.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (isCap && char.IsLetter(chars[i]))
                {
                    chars[i] = char.ToUpper(chars[i]);
                    isCap = false;
                }

                if (chars[i] == '.' || chars[i] == '!' || chars[i] == '?')
                {
                    isCap = true;
                }
            }

            return new string(chars);
        }
    }
}
