using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler003
{
    class Program
    {
        static int GetDigitsSum(String val) {
            int sum = 0;
            foreach (char ch in val) {
                sum += int.Parse(ch.ToString());            
            }
            return sum;
        }

        static decimal GetLargestPrimeFactor(String numStr) {
            int nextPrime = 3;
            decimal num = decimal.Parse(numStr);
            int numRoot = (int) Math.Ceiling(Math.Sqrt(decimal.ToDouble(num)));
            List<int> PrimesList = new List<int>();
            List<int> DivisorsList = new List<int>();

            while (nextPrime < numRoot) {
                PrimesList.Add(nextPrime);
                while (decimal.Remainder(num, nextPrime) == 0) {
                    if (!DivisorsList.Contains(nextPrime)) DivisorsList.Add(nextPrime);

                    num = decimal.Divide(num, nextPrime);
                    numRoot = (int)Math.Ceiling(Math.Sqrt(decimal.ToDouble(num)));
                }
                
                while (PrimesList.Any(i => nextPrime % i == 0) && nextPrime < numRoot) nextPrime += 2;
            }

            return Math.Max(num, nextPrime);
        }

        static void Main(string[] args)
        {
            const String num = "600851475143";
            Console.Write("Sum of number digits is {0} \n", GetDigitsSum(num));
            Console.Write("largest prime factor of the number {0} is {1} \n", num, GetLargestPrimeFactor(num));
        }
    }
}
