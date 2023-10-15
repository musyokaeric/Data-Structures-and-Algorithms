using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class SumOfNumbers
    {
        public int SumofN(int n)
        {
            return n * (n + 1) / 2;
        }

        public int SumofNIteration(int n)
        {
            int total = 0;
            int i = 1;

            while (i <= n)
            {
                total += i;
                i += 1;
            }
            return total;
        }

        public int SumofNRecursion(int n)
        {
            if (n == 0) return 0;
            return SumofNRecursion(n - 1) + n;
        }
    }
}
