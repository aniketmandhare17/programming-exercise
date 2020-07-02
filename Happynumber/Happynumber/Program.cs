using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happynumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, temp, rem, sum = 0;
            Console.WriteLine("Enter the Number:");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while(sum!=1 && sum!=4)
            {
                sum = 0;
                while(temp!=0)
                {
                    rem = temp % 10;
                    sum = sum+ rem * rem;
                    temp = temp / 10;
                }
                temp = sum;
            }
            if (sum == 1)
                Console.WriteLine("Number is Happy Number:");
            else
                Console.WriteLine("Number is Not Happy Number:");
            Console.ReadLine();

        }
    }
}
