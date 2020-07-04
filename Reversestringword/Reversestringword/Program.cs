using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversestringword
{
    class Program
    {
        static void Main(string[] args)
        {
        
            
            Console.WriteLine("Enter the String Which u have Reversed:");
            string   s = (Console.ReadLine());

            string[]  A = s.Split('.');
            string ans= "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                ans += s[i] + "";
            }
            Console.Write("Reversed String is the:");
            Console.Write(ans);
            Console.ReadLine();
        }
     }
}
