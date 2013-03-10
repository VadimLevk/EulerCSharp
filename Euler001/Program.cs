using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler001
{
    class Program
    {
        static int GetDivisorsCountUptoLimit(int limit, int divisor)
        {
            return limit / divisor;
        }

        static int GetArithProgressionSum(int progressionStep, int count)
        {
            return (((count + 1) * count) / 2) * progressionStep;
        }

        static int GetSumOfDivisorUptoLimit(int divisor, int limit) {
            return GetArithProgressionSum(divisor, GetDivisorsCountUptoLimit(limit, divisor));
        }


        static void Main(string[] args)
        {
            const int limit = 999;
            int sum = GetSumOfDivisorUptoLimit(3, limit) + GetSumOfDivisorUptoLimit(5, limit) - GetSumOfDivisorUptoLimit(3*5, limit);
            Console.Write("Sum of natural numbers below {0} that are multiples of 3 or 5 is {1} \n", new object[] {limit, sum});
        }
    }
}
