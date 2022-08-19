using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _3_LengthOfLongestSubstring
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s is null || s == string.Empty) return 0;

            HashSet<char> set = new HashSet<char>();
            int max = 0, left = 0, right = 0;

            while (right < s.Length)
            {
                if (!set.Contains(s[right]))
                {
                    set.Add(s[right]);
                    right++;
                    max = Math.Max(max, right - left);
                }
                else
                {
                    set.Remove(s[left]);
                    left++;
                }
            }
            return max;
        }
        //private static int LengthOfLongestSubstring_NOTGOOD(string s)
        //{

        //    if (s is null || s.Length == 0) return 0;

        //    Dictionary<int, char> dict = new Dictionary<int, char>();
        //    IList<String> list = new List<String>();
        //    int key = 0;
        //    for (int i = 0; i < s.Length; i++,key++)
        //    {
        //        String input = "";
        //        dict.Add(key, s[i]);
        //        Console.WriteLine("i = " + i + " key = " + key);
        //        key++;
        //        for (int j = i + 1; j < s.Length; j++,key++)
        //        {
        //            if (dict.ContainsValue(s[j]))
        //            {
        //                foreach (var a in dict) Console.WriteLine("dict Key: {0}, Value: {1}", a.Key, a.Value);
        //                foreach (var a in dict) input += a.Value.ToString();
        //                dict.Clear();
        //                list.Add(input);
        //                Console.WriteLine("input: " +input);
        //                Console.WriteLine("==================================");
        //                break;
        //            }
        //            else
        //            {
        //                dict.Add(key, s[j]);
        //                if (j == s.Length - 1)
        //                {
        //                    foreach (var a in dict) Console.WriteLine("dict Key: {0}, Value: {1}", a.Key, a.Value);
        //                    foreach (var a in dict) input += a.Value.ToString();
        //                    dict.Clear();
        //                    list.Add(input);
        //                    Console.WriteLine("input: " + input);
        //                    Console.WriteLine("==================================");
        //                }
        //                Console.WriteLine("i = " + i + " key = " + key);
        //            }
        //        }


        //    }
        //    foreach (string a in list) Console.WriteLine(a);
        //    return list.Max(x => x.Length);
        //}
    }
}
