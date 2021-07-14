using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1
{
    class b10
    {
        public static void u10()
        {
            char s;

            Console.Write("Nhap mot chu bat ky: ");
            s = Convert.ToChar(Console.ReadLine());

            if ((s == 'u') || (s == 'e') || (s == 'o') ||(s == 'a') || (s == 'i'))
                Console.WriteLine("Chu vua nhap la nguyen am.");
            else if ((s >= '0') && (s <= '9'))
                Console.WriteLine("Chu vua nhap la chu so.");
            else
                Console.WriteLine("Ky tu khac.");

            Console.ReadKey();

        }
    }
}
