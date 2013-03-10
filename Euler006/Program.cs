using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler006
{
    class Program
    {
        static int GetSumSqsMinusSqSum(int limit) {
            int result = 0;
            int sum = limit * (limit+1) / 2;
            for (int i = 1; i < limit; i++) {
                sum -= i;
                result += i * sum;
            }

            return result * 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Difference between the sum of the squares of the first ten natural numbers and the square of the sum is {0}", GetSumSqsMinusSqSum(10));
            Console.WriteLine("Difference between the sum of the squares of the first one hundred natural numbers and the square of the sum is {0}", GetSumSqsMinusSqSum(100));
        }
    }
}
