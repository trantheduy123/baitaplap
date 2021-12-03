using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLap6_b2
{
    internal class Program
    {
        static int power(int a, int n)
        {
            int ket_qua = 1;
            int i;
            for (i = 1; i <= n; i++)
                ket_qua = ket_qua * a;
            Console.WriteLine(ket_qua);
            return ket_qua;               
        }
    
        static void Main(string[] args)
        {
            int a;
            int n;
            Console.WriteLine("Nhap con so : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap luy thua : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("gia tri cua {0}^{1}={2}",a,n, power(a,n));            
            Console.ReadKey();

        }
    }
}
