using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler002
{
    class Program
    {
        static void Main(string[] args)
        {
            const int limit = 4000000;
            Int64 f_prev = 1, f_cur = 1, f_tmp, sum = 0;

            while (f_cur < limit)
            {
                if (f_cur % 2 == 0) { sum += f_cur; }

                f_tmp = f_prev + f_cur;
                f_prev = f_cur;
                f_cur = f_tmp;
            }

            Console.Write("Sum of terms in the Fibonacci sequence whose values do not exceed four million and is even equal to {0} \n", sum);
        }
    }
}
