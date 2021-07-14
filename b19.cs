using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1
{
    class b19
    {
        public static void u19() {
            float h;

            Console.Write("Nhap chieu cao cua ban (cm): ");
            h =float.Parse(Console.ReadLine());

            if (h < 150.0)
                Console.WriteLine("Phan loai: nguoi lun ");
            else if (h >= 150.0 && h <= 165.0)
                Console.WriteLine("Phan loai: do cao trung binh");
            else if (h >= 165.0 && h <= 195.0)
                Console.WriteLine("Phan loai: cao ");
            else
                Console.WriteLine("Phan loai: chieu cao bat thuong");

            Console.ReadKey();
        }

    }
}
