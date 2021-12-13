using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blap4_baitap7
{
    internal class Program
    {
        static void Main(string[] args)
        
            {
                int i, n;
                Console.Write("Nhap n = ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Tat ca cac so nguyen to nho hon {0} la:", n);
                if (n >= 2)
                {
                    Console.Write("{0} ", 2);
                }
                for (i = 3; i < n; i += 2)
                {
                    if (isPrimeNumber(i) == 1)
                    {
                        Console.Write("{0} ", i);
                    }
                }

                Console.WriteLine();
                Console.ReadKey();
            }

            /**
             * check so nguyen to
             * 
             * @author viettuts.vn
             * @param n: so nguyen duong
             * @return 1: la so nguyen so, 
             *         0: khong la so nguyen to
             */
            static int isPrimeNumber(int n)
            {
                // so nguyen n < 2 khong phai la so nguyen to
                if (n < 2)
                {
                    return 0;
                }
                // check so nguyen to khi n >= 2
                int i;
                int squareRoot = (int)Math.Sqrt(n);
                for (i = 2; i <= squareRoot; i++)
                {
                    if (n % i == 0)
                    {
                        return 0;
                    }
                }
                return 1;
            }

        }
    }

