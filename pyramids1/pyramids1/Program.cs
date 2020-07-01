using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyramids1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows;
            Console.WriteLine("enter the numer of rows: ");
            rows=Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows;++i)
            {
                for (j = 1; j <= i; ++j) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
