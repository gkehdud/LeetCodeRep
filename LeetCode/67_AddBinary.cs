using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _67_AddBinary
    {
        public string AddBinary(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int MaxSize = Math.Max(a.Length, b.Length);
            for (int i = MaxSize; i >= 0; i--)
            {
                if (a.Length < MaxSize) a = "0" + a;
                if (b.Length < MaxSize) b = "0" + b;
            }
            int n = 0, carry = 0;
            while (n < MaxSize)
            {
                int aint = a[a.Length - n - 1] == '1' ? 1 : 0;
                int bint = b[b.Length - n - 1] == '1' ? 1 : 0;
                int sum = aint + bint + carry;
                carry = sum > 1 ? 1 : 0;
                sum %= 2;
                n++;
                sb.Append(sum);
            }
            if (carry == 1)
            {
                sb.Append("1");
            }
            return new String(sb.ToString().Reverse().ToArray());

        }
    }
}
