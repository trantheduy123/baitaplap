using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blap6_BT1
{
    internal class Program
    {
        static void GiaiPT2(float a, float b, float c)
        {
            if ( a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("PT vo nghiem!");
                }
                else
                {
                    Console.WriteLine("PT co mot nghiem : x ={0}", (-c / b));
                }
                return;
            }
            // tinh delta
            float delta = b * b - 4 * a * c;
            float x1;
            float x2;
            //tinh nghiem
            if (delta > 0)
            {
                x1 = (float)((-b +Math.Sqrt(delta)) / (2 *a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("PT co 2 nghiem la : x1 ={0} va x2 = {1}", x1, x2);
            }
            else if ( delta == 0)
            {
                x1 = (-b / (2 *a));
                Console.WriteLine("PT co nghiem kep: x1 = x2 = {0}", x1);
            }
            else
            {
                Console.WriteLine("PT vo nghiem!");
            }
        }

        
        static void Main(string[] args)
        {
            float a, b, c;
            Console.Write("Nhap he so bac 2 , a = ");
            string valA= Console.ReadLine();
            a = Convert.ToInt32(valA);
            Console.Write("Nhap he so bac 1 , b = ");
            string valB = Console.ReadLine();
            b = Convert.ToInt32(valB);
            Console.Write("Nhap he so bac 0 , c = ");
            string valC = Console.ReadLine();
            c = Convert.ToInt32(valC);
            GiaiPT2(a, b, c);
        }
    }
}
