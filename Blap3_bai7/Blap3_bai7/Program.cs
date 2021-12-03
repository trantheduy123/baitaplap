using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blap3_bai7
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("MENU");
            Console.WriteLine("===========");
            Console.WriteLine("1.CF");
            Console.WriteLine("2.C");
            Console.WriteLine("3.HDJ");
            Console.WriteLine("4.Dreamweaver");
            Console.WriteLine("5.Learn Java by example");
            Console.WriteLine("Chon :");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("ban chon " + number);
            if (number == 1)
             {
                Console.WriteLine("ban chon CF");
            }
            else if (number == 2)
            {
                Console.WriteLine("ban chon C");
            }

            else if (number == 3)
            {
                Console.WriteLine("ban chon HDJ");
            }

            else if (number == 4)
            {
                Console.WriteLine("ban chon Dreamweaver");
            }

            else if (number == 5)
            {
                Console.WriteLine("ban chon Learn Java by example");
            }
            else 
            
                Console.WriteLine("ban chon sai");
            
            Console.Read();
        }
    }
}
