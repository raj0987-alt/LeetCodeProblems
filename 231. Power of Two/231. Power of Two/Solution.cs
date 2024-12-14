using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231._Power_of_Two
{
    public class Solution
    {
        //With Out Loops

        public bool IsPowerOfTwo(int n)
        {
            return n > 0 && (n & (n - 1)) == 0;

        }
        //With Loops
        //public bool IsPowerOfTwo(int n)
        //{
        //    if (n == 1)
        //        return true;
        //    int m = 2;
        //    while (m <= n / 2)
        //    {
        //        m *= 2;
        //    }
        //    if (n == m)
        //        return true;
        //    return false;
        //}
        //public bool IsPowerOfTwo(int n)
        //{
        //    if(n==1) return true;
        //    if(n%2 == 1) return false;
        //    if(n <= 0) return false;

        //    while(n>2)
        //    {
        //        n /= 2;
        //        if(n%2 == 1)
        //            return false;

        //    }
        //    return true;

        //}

        //With Recursion
        //public long CheckPower(long n, long m)
        //{

        //    if (m >= n) return m;

        //    m *= 2;
        //    return CheckPower(n, m);
        //}

        //public bool IsPowerOfTwo(long n)
        //{
        //    long m = CheckPower(n, 2);
        //    if (m == n || n == 1) return true;
        //    return false;
        //}

        //public bool IsPowerOfTwo(int n)
        //{
        //    if (n == 1) return true;
        //    if (n % 2 == 1) return false;
        //    if (n <= 0) return false;
        //    return IsPowerOfTwo(n / 2);

        //}
    }
}
