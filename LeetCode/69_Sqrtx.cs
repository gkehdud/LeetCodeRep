using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _69_Sqrtx
    {
        public static int MySqrt(int x)
        {
           
            int i = 1;
            while (i * i < x)
            {
                i++;
            }
            if (i > x / i) return --i;
            return i;



            //double low = 0, high = x, res = 0;
            //while (low <= high)
            //{
            //    double mid = (low + high) / 2;
            //    double mulmid = mid * mid;

            //    if (mulmid == x)
            //    {
            //        return (int)mid;
            //    }
            //    else if (mulmid > x)
            //    {
            //        high = mid - 1;
            //    }
            //    else
            //    {
            //        low = mid + 1;
            //        res = mid;
            //    }
            //}

            //return (int)res;



        }
    }
}
