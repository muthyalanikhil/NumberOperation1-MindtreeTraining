using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOperationTest
{
    public class Number
    {
        public int AddDigits(int number)
        {
            int sum = 0;
            while (number != 0)                         // Sum of digit
            {
                sum = sum + (number % 10);
                number = number / 10;
            }
            if (sum < 0)                                // if input number is negative
            {
                sum = sum * -1;
            }
            return sum;
        }

        public int DivideDigits(int number)
        {
            int quotient = 0;
            while (number != 0)                         
            {
                quotient = number/(number % 10);
            }
            if (quotient < 0)                                
            {
                quotient = quotient * -1;
            }
            return quotient;
        }
    }
}
