using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blap6_bai3
{
    internal class Program
    {
        static int fibo(int n)
        {
         int f0 =0;
         int f1 = 1;
         int f2 = 1;
         int i ;
            if (n < 0)
            {
                return -1;
            }
            else if ( n == 0 || n == 1)
            {
                return n;
            }    
            else
            {
                for (i= 2; i < n; i++)
                {
                    f0 = f1;
                    f1 = f2;
                    f2 = f0 + f1;
                }
            }
            return f2;
        }
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine(" 10 so dau tien cua day so fibonacci: \n");
            for ( i = 0 ; i < 10 ; i++)
            {
                Console.WriteLine("{0}", fibo(i));
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
