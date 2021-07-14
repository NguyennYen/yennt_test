using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1
{
    class b4
    {
        public static void u4()
        {
            string user, pass;
            int count = 0;
            Console.WriteLine("Kiem tra Username và Password:");
            Console.WriteLine("Gia tri mac dinh la: yen va 123456");

            do
            {
                Console.Write("Username: ");
                user = Console.ReadLine();

                Console.Write("Password: ");
                pass = Console.ReadLine();

                count++;

            }
            while (((user != "yen") || (pass != "123456")) && (count != 3));

            if (count == 3)
                Console.WriteLine("Dang nhap khong thanh cong!");
            else
                Console.WriteLine("Đang nhap thanh cong!");
            Console.ReadKey();
        }
    }
}
