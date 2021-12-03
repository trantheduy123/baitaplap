using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLap6_bai4
{
    internal class Program
    { 
        static float xep_loai( float n)
        {
            
            if (n < 3.9)
            {
                Console.WriteLine("ban duoc diem F");
            }
            else if (n < 5.4)
            {
                Console.WriteLine("ban duoc diem D");
            }
            else if (n < 6.9)
                Console.WriteLine("ban duoc diem C");
            else if (n < 8.4)
            {
                Console.WriteLine("ban duoc diem B");
            }
            else if (n < 10)
            {
                Console.WriteLine("ban duoc diem A");
            }
            else 
            {
                Console.WriteLine("EEEEEEE");
            }
            

        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("hay nhap diem so cua ban : \n ");
            float n = float.Parse(Console.ReadLine());
            xep_loai(n);
            Console.ReadKey();


        }
    }
}
