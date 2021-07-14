using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1
{
    class b31_cs
    {
        public static void u31()
        {
            int a;
            Console.Write("Nhap thang trong nam: ");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Thang co 31 ngay.");
                    break;
                case 2:
                    Console.WriteLine("Thang Hai co 28 ngay.");
                    Console.WriteLine("Trong nam nhuan: thang Hai co 29 ngay.");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang co 30 ngay.");
                    break;
                default:
                    Console.WriteLine("Vui long nhap lai");
                    break;
            }

            Console.ReadKey();
        }
    }
}
