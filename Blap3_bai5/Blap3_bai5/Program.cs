using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blap3_bai5
{
    internal class Program
    {
        static void Main()
        {
            float km;
            float x = 15000;   /*1 < số km ≤ 5 giá 13500đ */
            float y = 13500;  /*    km > 5 giá 11000đ */
            float z = 11000;  /* số km > 120 km sẽ được giảm 10% trên tổng số tiền */
            float c;  /* so tien */

            Console.WriteLine("nhap so km da di");
            km = Convert.ToSingle(Console.ReadLine());
            while (km < 0)
            {
                Console.WriteLine("so km phai lon hon 0 moi ban nhap lai");
                km = Convert.ToSingle(Console.ReadLine());

            }
            if (km <= 1)

            {
                c = km * x;
                Console.WriteLine(c);

            }
            else if (km <= 5)
            {
                c = km * y;
                Console.WriteLine(c);
            }

            else if (km > 5 && km <120 )
            {
                c = km * z;
                Console.WriteLine(c);
            }
            else if (km > 120)
            { 
                c = (km * z) - ((km * z) / 10 );
                Console.WriteLine(c);
            }
                    
            
                   

            

       
        }
    }
}
