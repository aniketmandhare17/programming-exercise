using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Q = new Queue();
            for (int i = 0; i < 5; i++)
            {
                Q.Enqueue(i + 1);

            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Q.Dequeue());
                


            }

                /*Stack s = new Stack();
                for (int i=0;i<5;i++)
                {
                    s.Push(i);


                }
                for(int i=0;i<5;i++)
                {
                    Console.WriteLine(s.Pop());
                }*/
                Console.ReadLine();
        }
    }
}
