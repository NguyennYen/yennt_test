using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1
{
    class b25
    {
        public static void u25(){
            int a=0, b=0, c=0, s=0;
            do
            {
                Console.WriteLine("Nhap vao 3 so đo goc nguyen duong a, b, c: ");
                a = int.Parse(Console.ReadLine());
                b= int.Parse(Console.ReadLine());
                c= int.Parse(Console.ReadLine());
            } while (a < 0 && b < 0 && c < 0);  
            s = a + b + c;
            if (s == 180)
            {
                Console.WriteLine("Day la ba goc cua tam giac.");
            }
            else
            {
                Console.WriteLine("Day khong phai la ba goc cua tam giac.");
            }
            Console.ReadKey();
        }
       
    }
}
