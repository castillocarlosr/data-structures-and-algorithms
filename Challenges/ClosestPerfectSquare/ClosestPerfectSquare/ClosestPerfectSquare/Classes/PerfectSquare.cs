using System;
namespace ClosestPerfectSquare.Classes
{
    public class PerfectSquare
    {
        public bool IsPerfectSquare(int input)
        {
            double squareDecimal = Math.Sqrt(input);
            int squareWhole = (int)Math.Sqrt(input);
            if((squareDecimal - (double)squareWhole) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
