using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blap3_bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so thu nhat");
              int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai");
              int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("MENU");
            Console.WriteLine("==============");
            Console.WriteLine("X");
            Console.WriteLine(":");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("==============");             
            Console.WriteLine("chon :" + Console.ReadLine());
            string a = Console.ReadLine();
            int b;
            

            if (a == "X")
            {
                Console.WriteLine("ban chon nhan");
                b = x * y;
                Console.WriteLine(b);
            }

            if (a == ":")
            {
                Console.WriteLine("ban chon thuong");
                b = x / y;
                Console.WriteLine(b);
            }

            if (a == "+")
            {
                Console.WriteLine("ban chon cong");
                b = x + y;
                Console.WriteLine(b);
            }

            if (a == "-")
            {
                Console.WriteLine("ban chon tru");
                b = x - y;
                Console.WriteLine(b);
            }
        }
    }
}
