// written by Chloe Jensrud
// 4/7/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeAlternately
{
    public class Solution
    {
        public string MergeAlternate(string word1, string word2)
        {
            int i = 0; int j = 0;
            string result = "";

            while( i < word1.Length || j < word2.Length)
            {
                if(i < word1.Length)
                {
                    result += word1[i]; i++;
                }
                if( j < word2.Length)
                {
                    result += word2[j]; j++;
                }
            }
            return result;
        }
    }
}
