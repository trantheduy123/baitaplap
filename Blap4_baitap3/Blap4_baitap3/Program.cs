using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blap4_baitap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n;
            int x;
            int y;
            Console.WriteLine("Nhap x va y dk x<y");
            Console.Write("Nhap x :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap y : ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x < y)
            {
                for (i = x ; i < y; i++)
                {
                    n = i%7;
                    if (n == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
