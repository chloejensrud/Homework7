// written by Chloe Jensrud
// 4/7/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCharacter
{
    public class Solution
    {
        public int FirstUniqueChar(string s)
        {
            int[] freq = new int[26];

            foreach(char c in s)
            {
                freq[c - 'a']++;
            }

            for(int i = 0; i < s.Length; i++)
            {
                if (freq[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
