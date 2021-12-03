using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blap6_bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("+-------------------+\n");
            Console.Write("+--------MENU-------+\n");
            Console.Write("+-------------------+\n");
            Console.WriteLine("1. Menu 1");
            Console.WriteLine("2. Menu 2");
            Console.WriteLine("3. Menu 3");
            Console.WriteLine("4. Menu 4");
            Console.WriteLine("5. EXit");

            int n=0;

            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1: Console.WriteLine("Ban chon 1"); break;
                    case 2: Console.WriteLine("Ban chon 2"); break;
                    case 3: Console.WriteLine("Ban chon 3"); break;
                    case 4: Console.WriteLine("Ban chon 4"); break;
                    case 5: Console.WriteLine("Ban chon 5"); n = 5; break;

                    default: Console.WriteLine(" not in 1..5 "); break;
                }

            } while (n != 5);
        }
    }
}
