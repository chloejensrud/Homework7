// written by Chloe Jensrud
// 4/7/2025

namespace RobotOrgin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution aSolution = new Solution();

            string moves = "UD";
            bool result = aSolution.FinalPlace(moves);

            Console.WriteLine(result);
        }
    }
}
