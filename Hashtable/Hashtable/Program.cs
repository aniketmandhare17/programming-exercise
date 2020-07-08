using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable H = new Hashtable ();
            H.Add("Name", "Aninet");
            H.Add("Add", "Pune");
            H.Add("Age", "22");
           
            Console.WriteLine(H["Name"]);

            Console.WriteLine(H["Name"]);
            Console.ReadLine();


        }
    }
}
