// written by Chloe Jensrud
// 4/7/2025

namespace FindTheDifference
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = "abcd";
            string t = "abcde";

            Solution aSolution = new Solution();

            char result = aSolution.FindTheDifference(s, t);

            Console.WriteLine($"The extra letter is {result}");
        }
    }
}
