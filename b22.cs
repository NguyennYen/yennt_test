using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1
{
    class b22
    {
        public static void u22()
        {
            float t, l, h;
            Console.WriteLine("Nhap vao diem toan, li, hoa: ");
            t = float.Parse(Console.ReadLine());
            l = float.Parse(Console.ReadLine());
            h = float.Parse(Console.ReadLine());

            float s, s1;
            s = (float)t + l + h;
            s1 = (float)t + l;
            Console.WriteLine("Tổng điểm 3 môn s={0} ", s);
            Console.WriteLine("Tổng điểm 2 môn s={0} ", s1);
            if (t >= 6.5)
                if (l >= 5.5)
                    if (h >= 5.0)
                        if (s >= 18.0 || s1 >= 14.0)
                            Console.WriteLine("Trúng tuyển");
                        else
                            Console.WriteLine("Không trúng tuyển");
                    else
                        Console.WriteLine("Không trúng tuyển");     
                else
                    Console.WriteLine("Không trúng tuyển");
            else
                Console.WriteLine("Không trúng tuyển");
            Console.ReadKey();
        }
    }
}
