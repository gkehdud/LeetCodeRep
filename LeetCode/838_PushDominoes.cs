using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/push-dominoes/
namespace LeetCode
{
    internal class _838_PushDominoes
    {
        public void start()
        {
            char[] chars = "L.R".ToCharArray();
            Random rand = new Random();
            Random num = new Random();
            string[] domiArray = new string[5];
            
            Console.WriteLine("838. Push Dominoes/ Medium");
            Console.WriteLine("There are n dominoes in a line, and we place each domino vertically upright.\n " +
                "In the beginning, we simultaneously push some of the dominoes either to the left or to the right.\n\n" +
                "After each second, each domino that is falling to the left pushes the adjacent domino on the left.\n" +
                " Similarly, the dominoes falling to the right push their adjacent dominoes standing on the right.\n\n" +
                "When a vertical domino has dominoes falling on it from both sides, \nit stays still due to the balance of the forces.\n\n" +
                "For the purposes of this question, we will consider that a falling domino expends \nno additional force to a falling or already fallen domino.\n\n" +
                "You are given a string dominoes representing the initial state where:\n" +
                "dominoes[i] = 'L', if the ith domino has been pushed to the left,\n" +
                "dominoes[i] = 'R', if the ith domino has been pushed to the right, and\n" +
                "dominoes[i] = '.', if the ith domino has not been pushed.\n" +
                "Return a string representing the final state.\n\n" +
                "Input: dominoes = \".L.R...LR..L..\"\nOutput: \"LL.RR.LLRRLL..\"\n" +
                "Constraints:\n" +
                "n == dominoes.length\n" +
                "1 <= n <= 105\n" +
                "dominoes[i] is either 'L', 'R', or '.'.\n\n" +
                "I'll give you 5 random example. (5 <= dominoes.Length <= 15)\n" +
                "===================================================================================================\n");
            for (int s = 0; s < domiArray.Length; s++)
            {
                string dominoes = "";
                int n = num.Next(5, 15);
                for (int i = 0; i < n; i++)
                {
                    int ch = rand.Next(0, chars.Length);
                    dominoes += chars[ch].ToString();
                }
                domiArray[s] = dominoes;

                Console.WriteLine("Example " +(s+1).ToString());
                Console.WriteLine("dominoes : " + dominoes);
                Console.WriteLine("result   : " + PushDominoes(dominoes));
                Console.WriteLine("\n");
            }
        }
        public string PushDominoes(string dominoes)
        {
            int head = 0;
            int tail = 1;
            char[] charr = new char[dominoes.Length + 2];

            // "...LRR..L"
            // "L...LRR..LR"
            for (int i = 0; i < charr.Length; i++)
            {
                if (i == 0) charr[i] = 'L';
                else if (i == charr.Length - 1) charr[i] = 'R';
                else charr[i] = dominoes[i - 1];
            }

            while (tail < charr.Length)
            {
                while (charr[tail] == '.') tail++;

                if (charr[head] == 'L' && charr[tail] == 'L')
                {
                    for (int i = head; i < tail; i++) charr[i] = 'L';
                    head = tail++;
                }
                else if (charr[head] == 'L' && charr[tail] == 'R')
                {
                    head = tail++;
                }
                else if (charr[head] == 'R' && charr[tail] == 'R')
                {
                    for (int i = head; i < tail; i++) charr[i] = 'R';
                    head = tail++;
                }
                else if (charr[head] == 'R' && charr[tail] == 'L')
                {
                    int i = head + 1;
                    int j = tail - 1;
                    while (i < j)
                    {
                        charr[i++] = 'R';
                        charr[j--] = 'L';
                    }
                    head = tail++;
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < charr.Length - 1; i++)
            {
                sb.Append(charr[i].ToString());
            }
            return sb.ToString();
        }
    }
}
