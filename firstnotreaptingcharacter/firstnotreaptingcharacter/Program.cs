using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstnotreaptingcharacter
{
    class NRW
    {
        static int NO_OF_CHARS = 256;
        static char[] count = new char[NO_OF_CHARS];


        static void getCharCountArray(string str)
        {
            for (int i = 0; i < str.Length; i++)
                count[str[i]]++;
        }


        static int firstNonRepeating(string str)
        {
            getCharCountArray(str);
            int index = -1, i;

            for (i = 0; i < str.Length; i++)
            {
                if (count[str[i]] == 1)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
            static void Main(string[] args)
            {

                string str = "aaniket";
                int index = firstNonRepeating(str);

                Console.WriteLine(index == -1 ? "Either "
                                                    + "all characters are repeating or string "
                                                    + "is empty"
                                              : "First non-repeating character"
                                                    + " is " + str[index]);
            Console.ReadLine();
             }


        }
    }











    
