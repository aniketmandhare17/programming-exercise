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
            Student.Add("Piu");
            Student.Add("Ankita");
            Student.Add("Aniket");
            Student.Add("Ritika");

            Console.WriteLine("Collection Student Name in Student List : ");

            foreach (var studentname in Student )
            {
                Console.WriteLine(studentname);
                
            }
            Console.WriteLine();

            Console.WriteLine("Remove operation on Student List : ");

            Console.WriteLine("\nRemove Student Name At Position (3)");
           
            Student.RemoveAt(3);

            Console.WriteLine();
            Console.WriteLine("After Removing Collection Student Name in Student List : ");
            foreach (var studentname in Student)
            {
                Console.WriteLine(studentname);

            }

            Console.WriteLine();
            Console.WriteLine("Search Student Name in Student List: ");

            Console.WriteLine("\nFind: Student where name contains \"Piu\": {0}",
                
            Student.Find(x => x.Contains("Piu")));

            Console.ReadLine();

        }
    }
}
