using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLap3_bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Nhap canh a:");
            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Nhap canh b:");
            b = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Nhap canh c:");
            c = Convert.ToSingle(Console.ReadLine());


            if (a + b > c && b + c > a && c + a > b)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Tam giac deu");
                }
                else if (a == b || a == c || c == b) ;
                {
                    if (a * a + b * b == c * c || a * a + c * c != b * b || a * a != b * b + c * c)
                    {
                        Console.WriteLine("Tam giac vuong can");
                    }
                    else
                    {
                        Console.WriteLine("Tam giac can");
                    }
                }
            }
            else if (a * a + b * b == c * c || a * a + c * c != b * b || a * a != b * b + c * c)
            {
                Console.WriteLine("Tam giac thuong");
            }
            else
                    {
                    Console.WriteLine("ba canh khong lap thanh tam giac");
                }

            }
        }
    }
