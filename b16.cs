using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1
{
    class b16
    {
        public static bool isLeapYear(int y)
        {
            if ((y % 400 == 0) || (y % 4 == 0 && y % 100 != 0))
            {
                return true;
            }

            return false;
        }
    }
}
