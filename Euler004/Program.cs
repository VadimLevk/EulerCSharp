using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler004
{
    class Program
    {
        static bool isPalindrom(int num) {
            String s = num.ToString();
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            String s_reversed = new String(charArray);

            return s.CompareTo(s_reversed) == 0;
        }

        static int GetLargestPalindromForLimits(int limMin, int limMax) {
            int x = limMax, y, val;
            List<int> Palindroms = new List<int>();

            while (x > limMin)
            {
                x--;
                y = x + 1;

                bool x_div_2 = (x % 2 == 0), x_div_5 = (x % 5 == 0), x_div_11 = (x % 11 == 0);

                if (!(x_div_2 & x_div_5))
                    while (y > limMin)
                    {
                        y--;
                        if (x_div_2 & (y % 5 == 0)) continue;
                        if (x_div_5 & (y % 2 == 0)) continue;
                        if (x_div_11 || (y % 11 == 0))
                        {
                            val = x * y;
                            if (!Palindroms.Contains(val) && isPalindrom(val)) Palindroms.Add(val);
                        }
                    }
            }

            return (Palindroms.Count > 0) ? Palindroms.Max() : 0;
        }

        static void Main(string[] args)
        {
            int limMin = 100, limMax = 1000;

            //Console.Write("test {0}. ", isPalindrom(123521));        

            Console.Write("Largest palindrome made from the product of two 3-digit numbers is {0} \n", GetLargestPalindromForLimits(limMin, limMax));
        }
    }
}
