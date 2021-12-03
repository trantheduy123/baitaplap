using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLuyenTap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
            if (snt(n))
            {
                Console.WriteLine("{0} prime", n);
            }
            else
            {
                Console.WriteLine("{0} prime", n);
            }
        }    
        

        static bool snt(int n)
        {
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) count++;
            } ;
            if (count == 0)  return true;
            else return false;

            }
        }        
}
