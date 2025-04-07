// written by Chloe Jensrud
// 4/7/2025

namespace MaxBaloons
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "loonbalxballpoon";

            Solution solution = new Solution();
            int result = solution.MaxNumberOfBaloons(text);

            Console.WriteLine($"{result}");
        }
    }
}
