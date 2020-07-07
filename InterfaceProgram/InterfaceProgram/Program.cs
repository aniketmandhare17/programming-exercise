using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProgram
{
   public  interface Car
    {
         void Accept();
         void Display();
    }
    class Honda: Car
    {
        int ID;
        String name;
        public void Accept()
        {
            
            Console.WriteLine("Enter the Car ID:");
            ID = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter the Car Name:");
            name =(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Car ID is :"+ID);
            Console.WriteLine("Car Name is :"+name);
        }
       
        static void Main(string[] args)
        {
            Honda C = new Honda();
            C.Accept();
            C.Display();
            Console.ReadLine();


        }
    }
}
