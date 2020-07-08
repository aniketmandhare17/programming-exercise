using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name;
            Gender gender;
            Console.WriteLine("Enter Your Name:");
            Name = Console.ReadLine();
            Console.WriteLine("0 Male,1 Female, 3 Other");
            int i = int.Parse(Console.ReadLine());
            gender = (Gender) i;
            Console.WriteLine(" My Name is {0} & My Gender is {1}",Name, gender);
            Console.ReadLine();

        }
        enum Gender { Male,Female,Other}
       

    }
}
