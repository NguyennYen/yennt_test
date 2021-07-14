using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1
{
    class b1
    {
        public static void daochuoi(){
        string s, s1 = "";
        Console.WriteLine("Nhap mot chuoi: ");
            s = Console.ReadLine();

            int l = s.Length - 1;
            for (int i = l; i >= 0; i--)
            {
                s1 = s1 + s[i];
            }
        Console.WriteLine("Chuoi dao nguoc la: {0}", s1);

            Console.ReadKey();}
    }
}
