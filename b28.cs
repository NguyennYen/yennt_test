using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1
{
    class b28
    {
        public static void u28()
        {
            string result;
            char c;
            Console.Write("Nhap hang cua ban: ");
            c = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (c)
            {
                case 'E':
                    result = "Xuat sac";
                    break;
                case 'V':
                    result = "Rat gioi";
                    break;
                case 'G':
                    result = "Gioi ";
                    break;
                case 'A':
                    result = "Trung binh";
                    break;
                case 'F':
                    result = "Truot";
                    break;
                default:
                    result = "Moi ban nhap lai hang";
                    break;
                    }
                    Console.WriteLine("Hang cua ban la: {0}", result);

                    Console.ReadKey();
            }
        }
    }
}
