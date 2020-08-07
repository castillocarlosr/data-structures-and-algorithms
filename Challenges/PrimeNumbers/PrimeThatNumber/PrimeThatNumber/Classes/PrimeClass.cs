using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeThatNumber.Classes
{
    public class PrimeClass
    {
        public int IsPrime(int number)
        {
            /**** for positive numbers only.  Otherwise I can set to return -1 ****/
            int yesPrime = 1;
            if (number == 1) return yesPrime;
            int primeCounter = 0;
            for (int i = 1; i <= number; i++)
            {
                if(number%i == 0)
                {
                    primeCounter++;
                }
                if(primeCounter >= 3)
                {
                    break;
                }
            }
            if(primeCounter == 2)
            {
                return yesPrime;
            }
            else /* Find the lowest prime number for the input */
            {
                if(number%2 == 0)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

    }
}
