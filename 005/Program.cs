using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005
{
    class Program
    {
        static decimal GetMinEvenlyDivisible(int limit) {
            List<int> PrimesList = new List<int>();
            int[] GoalNumberDivisors = new int[limit + 1];
            Array.Clear(GoalNumberDivisors, 0, GoalNumberDivisors.Length);
            
            int[] NumberDivisors = new int[limit + 1];

            for (int i = 2; i <= limit; i++) {
                int test = i;
                Array.Clear(NumberDivisors, 0, GoalNumberDivisors.Length);
                foreach (int prime in PrimesList) {
                    while (test % prime == 0) {
                        NumberDivisors[prime]++;
                        test =  test / prime;
                    }
                }
                if (test == i) {
                    PrimesList.Add(i);
                    NumberDivisors[i]++;
                }

                for (int j = 2; j <= limit; j++) 
                    GoalNumberDivisors[j] = Math.Max(GoalNumberDivisors[j], NumberDivisors[j]);
            }

            decimal result = 1;
            for (int i = 2; i <= limit; i++)
                if (GoalNumberDivisors[i] > 0)
                    result = decimal.Multiply(result, (int)Math.Pow(i, GoalNumberDivisors[i]));

            return result;
        }
        static void Main(string[] args)
        {
            const int limit = 20;
            Console.WriteLine("smallest positive number that is evenly divisible by all of the numbers from 1 to {0} is {1}", limit, GetMinEvenlyDivisible(limit));            
        }

    }
}
