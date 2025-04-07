// written by Chloe Jensrud
// 4/7/2025

namespace NumberOfSegments
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution aSolution = new Solution();

            string s = "Hello, my name is John";
            int result = aSolution.CountSegment(s);
            
            Console.WriteLine(result);
        }
    }
}
