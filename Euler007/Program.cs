using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler007
{
    class Program
    {
        static List<int> _Primes = new List<int>();

        static int Prime(int idx) {
            if (_Primes.Count < idx) {
                _Primes.Add(2); 
                int nextPrime = 3;

                while (_Primes.Count < idx) {
                    if (_Primes.All(x => nextPrime % x != 0)) 
                        _Primes.Add(nextPrime);

                    nextPrime += 2;
                }
            }

            return _Primes.ElementAt(idx - 1);
        }
        
        static void Main(string[] args)
        {
            const int necessaryPrimeIndex = 10001;
            Console.WriteLine("{0}st prime number is {1}", necessaryPrimeIndex, Prime(necessaryPrimeIndex));
        }

    }
}
