using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProgMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Marks = { 23, 56, 78, 34, 12 };
            IEnumerable<int> result = from p1 in Marks
                                      where p1 % 2 == 0
                                      select p1;
            Console.WriteLine("Even Number in Above Array is : ");
            foreach (int data in result)
            {
                 Console.WriteLine(data );

            }
            Console.ReadLine();


        }
    }
}
