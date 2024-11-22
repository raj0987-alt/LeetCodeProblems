using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _509._Fibonacci_Number
{
    public class Solution
    {
        // Implementing By Recursion
        public int Fib(int n)
        {
            int f = 0;
            
            return f;
        }

        // Implementing By Iterating
        public int ItrFib(int n)
        {
            if (n == 1 || n == 2)
                return 1;

            int n1 = 1, n2 = 1, f = 0;

            for (int i = 3; i <= n; i++)
            {
                f = n1 + n2;
                n1 = n2;
                n2 = f;
            }

            return f;
        }

        
        
    }
}
