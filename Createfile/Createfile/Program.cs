using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Createfile
{
    class Program
    {
        static void Main(string[] args)
        {

           
                TextWriter tw = new StreamWriter("D:/AniketFile.txt", true);
                tw.WriteLine("Anu@17");
                tw.Close();

              Console.WriteLine("File Created:");
            StreamReader rw = new StreamReader("D:/AniketFile.txt");
            string t= rw.ReadLine();
            Console.WriteLine(t);
            Console.ReadLine();

            /* try
             {
                 TextWriter tw = new StreamWriter("D:/AniketFile.txt", true);
                 tw.WriteLine("Anu@17");
                 tw.Close();


             }
             catch(Exception e)
             {
                 Console.Write(e);

             }
             Console.WriteLine("File Created:");

             Console.ReadLine ();*/
        }

    }
}
