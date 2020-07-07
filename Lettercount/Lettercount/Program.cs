using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lettercount
{
    class Program
    {
        static void Main(string[] args)
        {
            String str;
            int i;
            Console.WriteLine("Enter The String");
           str=(Console.ReadLine());

            while(str.Length >0)
            {
                int Count = 0;
                Console.WriteLine($"{str[0]}=>");
                for (i = 0; i < str.Length; i++) 
                {
                    if(str[0]==str[i])
                    {
                        Count++;

                    }
                }
                Console.WriteLine(Count );
               str= str.Replace(str[0].ToString(),string.Empty);

            }
           
 Console.ReadLine();
           
        }
    }
}
