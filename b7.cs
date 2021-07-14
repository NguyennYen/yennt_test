using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1
{
    class b7
    {
        public static void u7() {
            int x, y;

            Console.WriteLine("x = y^2 - 2y +1");
            Console.WriteLine();

            for (y = -5; y <= 5; y++)
            {
                x = y * y - 2 * y + 1;
                Console.WriteLine("y = {0} ; x=({0}*{0}) - 2*({0}) +1 = {1}", y, x);
            }

            Console.ReadKey();    
        }
       
    }
}
