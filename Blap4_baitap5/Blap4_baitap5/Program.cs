using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blap4_baitap5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap mot so nguyen duong n :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("tong cac chu so cua {0} la : {1}", n, totalDigitsOfNumber(n));
            Console.WriteLine();
            Console.ReadKey();
        }

        static int totalDigitsOfNumber( int n)
        {
            int x = 10;
            int total = 0;
            do
            {
                total = total + n % x;
                n = n / 10;
            }while (n > 0);
            return total;
            
        }
    }
}

    
