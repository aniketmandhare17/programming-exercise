using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringpalingrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, r="";
            Console.WriteLine("enter the string:");
            s1 = (Console.ReadLine());
            for(int i=s1.Length -1;i>=0;i--)
            {
                r += s1[i].ToString();
            }
            if(r==s1)
            {
                Console.WriteLine("string is Palindrom");

            }
            else
            {
                Console.WriteLine("string is not Palindrom");
            }
            Console.ReadLine();
        }
    }
}
