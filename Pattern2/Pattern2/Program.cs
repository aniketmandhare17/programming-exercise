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
            int i,j,rows,k=0;
            Console.WriteLine("enter num of rows:");
            rows=Convert.ToInt32(Console .ReadLine());
              for(i=1;i<=rows;++i,k=0)
            {
                for (j = 1; j <= rows - i;++j)
                {
                    Console.WriteLine(" ");
          
                }
                while(k!=2*i-1)
                {
                    Console.WriteLine("*");
                    ++k;

                }
                Console.ReadLine();
            }
            

        }
    }
}
