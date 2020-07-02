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
              for(i=1;i<=rows;i++)
            {
                for (j = i; j <rows ;j++)
                {
                    Console.WriteLine(" ");
          
                }
                for (rows = 1; rows <( i*2); rows++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                
            }

            Console.ReadLine();
        }
    }
}
