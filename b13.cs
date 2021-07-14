using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1
{
    class b13
    {
        public static void u13 (){
            int a=0,  b = 0;
            Console.WriteLine("Nhap vao 2 so a, b: ");
            try
            {

                a = Int32.Parse(Console.ReadLine());
                b = Int32.Parse(Console.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine("Loi dinh dang " + e.Message);
            }
            finally
            {
                if (a == b)
                {
                    Console.WriteLine("2 so bang nhau");
                }
                else
                {
                    Console.WriteLine("2 so khong bang nhau");
                }
            }

            Console.ReadKey();
        }
    }
}
