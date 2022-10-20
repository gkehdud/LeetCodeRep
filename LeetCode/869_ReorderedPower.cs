using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _869_ReorderedPower
    {
        public int MaxValue = 1000000000;
        HashSet<string> hset = new HashSet<string>();
        Random r = new Random();
        public int trial = 0;
        public void Start()
        {
            Console.WriteLine("==========================================================================================================");
            Console.WriteLine("869. Reordered Power of 2");
            Console.WriteLine("You are given an integer n." +
                "\nWe reorder the digits in any order (including the original order) such that the leading digit is not zero." +
                "\nReturn true if and only if we can do this so that the resulting number is a power of two.");
            Console.WriteLine("==========================================================================================================\n");
            
            SetUpHashSet();
            ReorderedPowerOf2(r.Next(1, MaxValue));
        }
        public void SetUpHashSet()
        {
            int i = 0;
            while (Convert.ToInt32(Math.Pow(2, i)) < MaxValue)
            {
                hset.Add(Ordered(Convert.ToInt32(Math.Pow(2, i))));
                i++;
            }
            PrintHashSet(hset);
            Console.WriteLine();
        }
        public void ReorderedPowerOf2(int n)
        {
            trial++;
            if (trial > 2000)
            {
                Console.WriteLine("\nTried 2000 times but failed. Close it and try again.");
                return;
            }
            
            if (hset.Contains(Ordered(n)))
            {
                Console.WriteLine("======================================================");
                Console.WriteLine($"n : {n}     ({Ordered(n)})   True  trial : {trial}");
                Console.WriteLine("======================================================");
                return;
            }
            Console.WriteLine($"n : {n}     ({Ordered(n)})   False");
            ReorderedPowerOf2(r.Next(1, MaxValue));
        }
        public string Ordered(int n)
        {
            return new String(n.ToString().ToCharArray().OrderBy(c => c).ToArray());
        }
        public void PrintHashSet(HashSet<string> hset)
        {
            Console.Write("[");
            for(int i = 0; i < hset.Count; i++) {
                Console.Write(hset.ElementAt(i)+"("+ Convert.ToInt32(Math.Pow(2, i))+")");
                if (i != hset.Count - 1) Console.WriteLine(", ");
            }
            Console.WriteLine("]");
        }
    }
}
