using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _202_HappyNumber
    {
        public void Start()
        {
            Random r = new Random();
            int n = r.Next(1,Int32.MaxValue);
            Console.WriteLine("===============================================================================================");
            Console.WriteLine($"202. Happy\n Write an algorithm to determine if a number n is happy." +
                $"\nA happy number is a number defined by the following process:" +
                $"\nStarting with any positive integer, replace the number by the sum of the squares of its digits." +
                $"\nRepeat the process until the number equals 1 (where it will stay), " +
                $"\nor it loops endlessly in a cycle which does not include 1." +
                $"\nThose numbers for which this process ends in 1 are happy." +
                $"\nReturn true if n is a happy number, and false if not.\n1 <= n <= Math.Pow(2,31)-1 (Int32.MaxValue) \n\nn = {n}");

            Console.WriteLine("===============================================================================================\n");

            Console.WriteLine("\n\nIsHappy ? " +IsHappy(n).ToString());
        }
        public bool IsHappy(int n)
        {
            List<int> list = new List<int>();
            while (n != 1)
            {
                char[] c = n.ToString().ToCharArray();
                n = 0;
                for (int i = 0; i < c.Length; i++)
                {

                    int number = Convert.ToInt32(c[i].ToString());
                    n += Convert.ToInt32(Math.Pow(number, 2));
                    Console.Write(Convert.ToInt32(Math.Pow(number, 2)));
                    if (i != c.Length - 1) Console.Write(" + ");

                }

                Console.Write(" = " + n);
                if (list.Contains(n)) return false;
                list.Add(n);

                PrintList(list);
            }
            return true;
        }
        public void PrintList(List<int> list)
        {
            Console.Write(" ====> [");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i != list.Count - 1)
                {
                    Console.Write(",");
                    Console.Write(" ");
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
