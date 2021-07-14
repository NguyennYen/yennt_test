using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1
{
    class b32
    {
        public static void u32()
        {
            int lua_chon, bk, d, r, ch, h;
            double dien_tich = 0;

            Console.WriteLine("Lua chon 1: tinh dien tich hinh tron");
            Console.WriteLine("Lua chon 2: tinh dien tich hinh chu nhat");
            Console.WriteLine("Lua chon 3: tinh dien tich hinh tam giac");
            Console.WriteLine("Nhap lua chon cua ban: ");
            lua_chon = Convert.ToInt32(Console.ReadLine());

            switch (lua_chon)
            {
                case 1:
                    Console.WriteLine("Nhap ban kinh hinh tron: ");
                    bk = Convert.ToInt32(Console.ReadLine());
                    dien_tich = 3.14 * bk * bk;
                    break;
                case 2:
                    Console.WriteLine("Nhap chieu dai HCN: ");
                    d= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap chieu rong HCN: ");
                    r = Convert.ToInt32(Console.ReadLine());
                    dien_tich = d * r;
                    break;
                case 3:
                    Console.WriteLine("Nhap canh huyen tam giac:");
                    ch = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap chieu cao tam giac:");
                    h = Convert.ToInt32(Console.ReadLine());
                    dien_tich = 0.5 * ch * h;
                    break;
            }
            Console.WriteLine("Dien tich hinh la: {0}\n", dien_tich);

            Console.ReadKey();
        }
    }
}
