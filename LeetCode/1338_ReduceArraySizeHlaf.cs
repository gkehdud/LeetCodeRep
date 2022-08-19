using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1338_ReduceArraySizeHlaf
    {
        public int MinSetSize(int[] arr)
        {
            if (arr is null || arr.Length < 2) return 0;
            int atleast = arr.Length / 2;
            int min = 0;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }

            var orderedDict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            int temp = 0;

            foreach (var a in orderedDict)
            {
                temp += a.Value;
                min++;
                if (temp >= atleast) return min;
            }

            return -1;
        }
    }
}
