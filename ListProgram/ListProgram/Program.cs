using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var Student = new List<string>();
            Student.Add("Aniket");
            Student.Add("Roshan");
            Student.Add("Pooja");
            Student.Add("Shree");
            Student.Add("piu");
            Student.Add("Ankita");
            Student.Add("Aniket");
            Student.Add("Ritika");

            foreach (var studentname in Student )
            {
                Console.WriteLine(studentname);
            }
            Console.ReadLine();

        }
    }
}
