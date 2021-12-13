using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blap4_baitap6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int x;
            Console.WriteLine("n so dau dien cua day so Fibonacci: \n");
            Console.WriteLine("nhap n :");
            x = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < x; i++)
            {
                Console.WriteLine(" {0}", fibonacci(i));
            }
            Console.WriteLine();
            Console.ReadKey();

        }

        static int fibonacci(int n)
        {
            int i;
            int f0 = 0;
            int f1 = 1;
            int fn = 1;

            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                for (i = 2; i < n; i++)
                {
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;
                }
            }
            return fn;
        }
    }
}
