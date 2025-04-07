// written by Chloe Jensrud
// 4/7/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotOrgin
{
    public class Solution
    {
        public bool FinalPlace(string moves)
        {
            int x = 0; int y = 0; 

            foreach(char move in moves)
            {
                if (move == 'R')
                { x++; }
                else if (move == 'L')
                { x--; }
                else if (move == 'U')
                { y++; }
                else if (move == 'D')
                { y--; }
            }
            return x == 0 && y == 0;
        }
    }
}
