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

        public int FindClosestSquare(int input)
        {
            if (IsPerfectSquare(input) == true)
            {
                return input;
            }
            else
            {
                int aboveInput;
                int belowInput;
                int n1;
                int n2;

                n1 = input + 1;
                while (true)
                {
                    if (IsPerfectSquare(n1) == true)
                    {
                        aboveInput = n1;
                        break;
                    }
                    else
                    {
                        n1++;
                    }
                }

                n2 = input - 1;
                while (true)
                {
                    if (IsPerfectSquare(n2) == true)
                    {
                        belowInput = n2;
                        break;
                    }
                    else
                    {
                        n2--;
                    }
                }

                int diffAbove = aboveInput - input;
                int diffBelow = input - belowInput;
                if(diffAbove > diffBelow)
                {
                    return belowInput;
                }
                else
                {
                    return aboveInput;
                }
            }
        }
    }
}
