// written by Chloe Jensrud
// 4/7/2025

namespace UniqueCharacter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution aSolution = new Solution();

            string s = "loveleetcode";
            int result = aSolution.FirstUniqueChar(s);

            Console.WriteLine(result);
        }
    }
}
