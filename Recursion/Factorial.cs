using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Factorial
    {
        public int FactorialIterative(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;
            return fact;
        }

        public int FactorialRecursive(int n)
        {
            if (n == 0) return 1;
            return FactorialRecursive(n - 1) * n;
        }
    }
}
