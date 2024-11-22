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

        public int Fib(int n, Dictionary<int, int> memo = null)
        {
            if (memo == null)
                memo = new Dictionary<int, int>();

            if (n == 0)
                return 0;
            if (n == 1 || n == 2)
                return 1;

            if (memo.ContainsKey(n))
                return memo[n];

            memo[n] = Fib(n - 1, memo) + Fib(n - 2, memo);
            return memo[n];

        }

        public int FibUn(int n)
        {
            Dictionary<int, int> memo = new Dictionary<int, int>();
            if (n == 1 || n == 2)
                return 1;
            if (n == 0)
                return 0;
            if(memo.ContainsKey(n))
            {
                return memo[n];
            }
            if (!memo.ContainsKey(n))
                memo.Add(n, Fib(n - 1, memo) + Fib(n - 2, memo));

            return memo[n];
        }





        // Implementing By Iterating
        public int ItrFib(int n)
        {
            //if (n == 1 || n == 2)
            //    return 1;

            //int n1 = 1, n2 = 1;

            //for (int i = 3; i <= n; i++)
            //{
            //    int temp = n2;
            //    n2 = n1 + n2;
            //    n1 = temp;
            //}

            //return n2;

            if (n <= 1) return n;
            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }
            return b;
        }

        
        
    }
}
