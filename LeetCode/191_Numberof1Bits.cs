using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _191_Numberof1Bits
    {
        public void Start()
        {
            Random r = new Random();
            //uint thirtyBits = (uint)r.Next(1 << 30);
            //uint twoBits = (uint)r.Next(1 << 2);
            //uint fullRange = (thirtyBits << 2) | twoBits;
            //uint ui = (uint)r.NextBytes(UInt32.MinValue, UInt32.MaxValue);
            //String bits = Convert.ToString(fullRange, 2);
            String ranbit = "";
            int i = 0;
            while (i < 32)
            {
                ranbit += r.Next(0, 2).ToString();
                i++;
            }
            r.Next(0, 1);
            uint n = Convert.ToUInt32(ranbit, 2);
            Console.WriteLine("191 : Write a function that takes an unsigned integer and returns the number of '1' bits " +
                "it has (also known as the Hamming weight).");
            Console.WriteLine($"Random n : {n}({ranbit})");

            HammingWeight(n);
        }
        public void HammingWeight(uint n)
        {
            int res = 0;
            while (n != 0)
            {
                if ((n & 1) == 1)   res++;
                n >>= 1;
            }
            Console.WriteLine($"Number of '1' bits : {res}");
        }
        
    }
}
