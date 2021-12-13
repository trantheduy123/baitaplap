using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blap4_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int chu_so, chu_cai, ki_tu_dac_biet, i, l;
            chu_cai = chu_so = ki_tu_dac_biet = i = 0;

            Console.Write("moi ban nhap 1 ky tu ban phim :  ");
            str = Console.ReadLine();
            //  l = str.Length;
            //while (true)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    Console.WriteLine("day la chu thuong");
                   
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    Console.WriteLine("day la chu so");
                   
                }
                else if ( str.Contains(" "))
                {
                    Console.WriteLine("out");
                }
                else
                {
                    Console.WriteLine("day la ky tu dat biet");
                   
                }

             
            }
        }
    }
}
