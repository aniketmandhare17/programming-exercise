using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;

            

            Console.Write("Input number of rows for this pattern :");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                
            }
            Console.ReadLine();


            /*  int i, num, px, py;
            int j;

            Console.WriteLine("enter num of rows:");
            num = Convert.ToInt32(Console.ReadLine());

            px = num;
            py = num;
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j < num * 2; j++)

                {
                    if (j >= px && j <= py)
                    {
                        Console.WriteLine("*");

                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                    px--;
                    py++;
                    
                }
                Console.ReadLine();
            }*/
        }
        

    }
}
