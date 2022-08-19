using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _804_UniqueMorseRepresentations
    {
        public static int UniqueMorseRepresentations(string[] words)
        {
            if (words is null) return 0;
            if (words.Length == 1) return 1;

            String[] Alphabet = new String[26]{".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--",
                                             "-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
            Dictionary<char, string> dic = new Dictionary<char, string>();

            for (int i = 97; i < 123; i++)
            {
                dic.Add((char)i, Alphabet[i - 97]);
            }
            String[] res = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                foreach (char c in words[i])
                {
                    res[i] += dic[c].ToString();
                }
            }
            Dictionary<int, string> transform = new Dictionary<int, string>();
            int key = 0;
            foreach (string word in res)
            {
                if (!transform.ContainsValue(word)) transform.Add(key, word);
                key++;
            }

            return transform.Count;
        }
    }
}
