using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1_TwoSum
    {
        private static int[] twosums = new int[]{ 3, 2, 4};
        private static int target = 6;
        public static int[] TwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2) return new int[2];

            Dictionary<int, int> Dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (Dic.ContainsKey(target - nums[i]))
                {
                    return new int[] { i, Dic[target - nums[i]] };
                }
                else if (!Dic.ContainsKey(nums[i]))
                {
                    Dic.Add(nums[i],i);
                }
            }
            return new int[2];
        }
        public static void QnA()
        {
            Console.WriteLine( "1. Two Sum\n\nGiven an array of integers nums and an integer target, return indices of the two numbers such that they add up to target." +
                "\nYou may assume that each input would have exactly one solution, and you may not use the same element twice.\nYou can return the answer in any order." +
                "\nExample 1:\rInput: nums = [2,7,11,15], target = 9\r\nOutput: [0,1]\r\nExplanation: Because nums[0] + nums[1] == 9, we return [0, 1].\r\nExample 2:\r\n\r\n" +
                "Input: nums = [3,2,4], target = 6\r\nOutput: [1,2]\r\nExample 3:\r\n\r\nInput: nums = [3,3], target = 6\r\nOutput: [0,1]\n\n");
            int[] result = TwoSum(twosums,target);

            foreach (int v in result)
            {
                Console.Write(v + " ");
            }
        }
    }
}
