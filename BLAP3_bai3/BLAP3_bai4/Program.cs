using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLAP3_bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(" Nhap a: ");
            int a = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(" Nhap b: ");
            int b = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(" Nhap c: ");
            int c = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(" Nhap d: ");
            int d = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c && c == d)
            {
                Console.WriteLine("Khong co gia tri nho nhat");
            }

            else 
            {
                int min = a;
                if (min > b)
                {
                    min = b;
                }
                if (min > c)
                {
                    min = c;
                }
                if (min > d)
                {
                    min = d;
                }
                Console.WriteLine($"Gia tri nho nhat trong 4 so la {min} ");
                int max = a;
                if (max < b)
                {
                    max = b;
                }
                if (max < c)
                {
                    max = c;
                }
                if (max < d)
                {
                    max = d;
                }
                Console.WriteLine($"Gia tri lon nhat nhat trong 4 so la {max} ");
            }
        }
    }
}
