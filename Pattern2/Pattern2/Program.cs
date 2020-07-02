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
            int i,j,rows;
            Console.WriteLine("enter num of rows:");
            rows=Convert.ToInt32(Console .ReadLine());
              for(i=0;i<rows;i++)
            {
                for (j = 1; j <= rows - i;j++)
                {
                    Console.WriteLine(" ");
          
                }
                for(j=1;j<=2*i-1;j++)
                {
                    Console.WriteLine("* ");

                   /* Console.WriteLine("\n");*/
                }
                
            }

            Console.ReadLine();
        }
    }
}
