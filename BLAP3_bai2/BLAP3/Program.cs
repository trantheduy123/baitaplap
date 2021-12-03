using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLAP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhap vao A");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao B");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao C");
            float c = float.Parse(Console.ReadLine());

            float delta = (b/2) * (b/2) - a * c;

            Console.WriteLine(" Delta phay = {0} ", delta);

            /* if (delta < 0 )
             {
                 Console.WriteLine("Chuong trinh vo nghiem");
             }
             else if (delta == 0)
             {
                 float x = (-b/2)/a;
                 Console.WriteLine("Phuong trinh co hai nghiem kep x1 = x2 = {0}" , x);
             }
             else
             {
                 float x1 = 0;
                 float x2 = 0;
                 x1 = (float)(((b / 2) / a - Math.Sqrt(delta)) / a);
                 x2 = (float)(((b / 2) / a + Math.Sqrt(delta)) / a);



                 Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                 Console.WriteLine("x1 ={0}", x1);
                 Console.WriteLine("x2 ={0}", x2);
             }
            */            
                switch (delta < 0)
            {
                case true:
                    Console.WriteLine("Chuong trinh vo nghiem");
                    break;
                 case false: 
                    switch (delta == 0)
                    {
                        case true:
                            float x = (-b / 2) / a;
                            Console.WriteLine("Phuong trinh co hai nghiem kep x1 = x2 = {0}", x);
                            break;
                        default:
                            float x1 = 0;
                            float x2 = 0;
                            x1 = (float)(((b / 2) / a - Math.Sqrt(delta)) / a);
                            x2 = (float)(((b / 2) / a + Math.Sqrt(delta)) / a);



                            Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                            Console.WriteLine("x1 ={0}", x1);
                            Console.WriteLine("x2 ={0}", x2);
                            break;
                    }
                    break;
            }
                    Console.ReadKey();
        }
    }
}
