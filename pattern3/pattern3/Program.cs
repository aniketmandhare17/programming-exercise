using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k,rows,s;
            
            Console.WriteLine("enter how many rows:");
            rows = Convert.ToInt32(Console.ReadLine());
            s = rows + 4 - 1;
            for (i=1;i<=rows;i++)
            {
                for(k=s;k>=1;k--)
                {
                    Console.Write(" ");
                }
                for(j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                s--;
            }
            Console.ReadLine();
        }
    }
}
