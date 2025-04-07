// written by Chloe Jensrud
// 4/7/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheDifference
{
    public class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            int result = 0;

            foreach (char c in s)
            {
                result ^= c;
            }

            foreach (char c in t)
            {
                result ^= c;
            }
            return (char)result;
        }
    }
}
