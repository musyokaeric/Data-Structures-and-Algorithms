using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class IterationVsRecursion
    {
        public void IterativeCalculation(int n)
        {
            while (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n -= 1;
            }
        }
        public void RecursiveCalculation(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                RecursiveCalculation(n - 1);
            }
        }
    }
}
