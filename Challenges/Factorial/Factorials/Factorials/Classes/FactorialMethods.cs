using System;
namespace Factorials.Classes
{
    public class FactorialMethods
    {
        public int FactorialAnswer(int inputFromUser)
        {
            if(inputFromUser == 1 || inputFromUser == 0)
            {
                return 1;
            }
            else
            {
                return inputFromUser * FactorialAnswer(inputFromUser - 1);
            }
        }
    }
}
