using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using u1;

namespace u1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 1");
            b1.daochuoi();
            Console.WriteLine("Bài 4");
            b4.u4();
            Console.WriteLine("Bài 7");
            b7.u7();
            Console.WriteLine("Bài 10");
            b10.u10();
            Console.WriteLine("Bài 13");
            b13.u13();
            Console.WriteLine("Bài 16");
            Console.Write("Nhap mot nam bat ky: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (b16.isLeapYear(year))
            {
                Console.WriteLine("{0} la nam nhuan", year);
            }
            else
            {
                Console.WriteLine("{0} khong la nam nhuan", year);
            }

            Console.WriteLine("Bài 19");
            b19.u19();
            Console.WriteLine("Bài 22");
            b22.u22();
            Console.WriteLine("Bài 25");
            b25.u25();
            Console.WriteLine("Bài 28");
            b28.u28();
            Console.WriteLine("Bài 31");
            b31_cs.u31();
            Console.WriteLine("Bài 32");
            b32.u32();
        }
    }
}
