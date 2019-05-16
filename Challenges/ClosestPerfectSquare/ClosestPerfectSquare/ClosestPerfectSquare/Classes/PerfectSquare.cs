using System;
namespace ClosestPerfectSquare.Classes
{
    public class PerfectSquare
    {
        public bool IsPerfectSquare(int input)
        {
            if (Math.Abs((Math.Sqrt(input) - (Math.Sqrt(input)))) == 0 )
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
