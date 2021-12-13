using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blap4_baitap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chon;
            Console.WriteLine("SO THICH CA NHAN");
            Console.WriteLine("----------------");
            Console.WriteLine("1. doc sach");
            Console.WriteLine("2. nghe nhac");
            Console.WriteLine("3. choi the thao");
            Console.WriteLine("4. may tinh");
            Console.WriteLine("5. thoat");
            Console.WriteLine("----------------");
            Console.Write("chon :");
            
            chon = Convert.ToInt32(Console.ReadLine());

                if (chon == 1)
                {
                    Console.WriteLine("ban thich doc sach");
                }
                else if (chon == 2)
                {
                    Console.WriteLine("ban thich nghe nhac");
                }
                else if (chon == 3)
                {
                    Console.WriteLine("ban thich choi the thao");
                }
                else if (chon == 4)
                {
                    Console.WriteLine("ban thich choi may tinh");
                }
             
            
            else if (chon == 5)
            {
                Console.WriteLine("thoat");
                Console.WriteLine("hen gap lai");
            }
        }
    }
}
