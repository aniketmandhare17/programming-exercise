using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringanagram
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 0, s = 0;
            string  str1,str2;
            Console.WriteLine("Enter the string 1:");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter the string 2:");
            str2 = Console.ReadLine();
            for (int i = 0; i<str1.Length ; i++)
            {
                f = f + str1[i];
            }
            for (int i = 0; i < str2.Length; i++)
            {
                s = s + str2[i];
            }
            if(f==s)
            {
                Console.WriteLine("String is Anagram :");
            }
            else
            {
                Console.WriteLine("String is Not Anagram :");
            }

            Console.ReadLine();

        }
    }
}
