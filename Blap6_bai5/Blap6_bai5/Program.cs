using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blap6_bai5
{
    internal class Program
    {
        static bool SNT(int x)
        {
            if ( x<2)
                return false;
            for(int i = 2; i < x/2;i++)
                if (x % i==0)
                return false;
            return true;
        }
        static void Main(string[] args)
        {
          int n;
            Console.WriteLine("nhap vao so nguyen duong : \n ");
            n = Convert.ToInt32(Console.ReadLine());
            if (SNT(n) == true)
            {
                Console.WriteLine("n la so nguyen to");
            }
            else
                Console.WriteLine("n khong la so nguyen to");



        }
    }
}
