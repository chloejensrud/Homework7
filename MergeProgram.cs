// written by Chloe Jensrud
// 4/7/2025

namespace MergeAlternately
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution aSolution = new Solution();

            string word1 = "abcd";
            string word2 = "pq";

            string result = aSolution.MergeAlternate(word1, word2);
            Console.WriteLine(result);
        }
    }
}
