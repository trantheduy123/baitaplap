using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blap4_bai2
{
    internal class Program
    {
        private static object letter;

        static void Main(string[] args)
        {    
            {  
                    for (char letter = 'A'; letter <= 'Z'; letter++)
                    {
                        Console.WriteLine(letter);
                    }
             }
                for (char number = '0'; number <= '9'; number++)
                {
                    Console.WriteLine(number);
                }
                 for (char letter = '!';  <= '+'; letter++)
            {
                Console.WriteLine(letter);
            }
        }






        }
    }
}
