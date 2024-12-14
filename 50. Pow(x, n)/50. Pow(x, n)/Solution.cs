using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50._Pow_x__n_
{
    public class Solution
    {
        //public double MyPow(double x, long n)
        //{
        //    double output = 1;
        //    if(n>=0)
        //    {
        //        for (long i = 0; i < n; i++)
        //        {
        //            output *= x;
        //        }
        //    }
        //    else
        //    {
        //        for (long i = 0; i > n; i--)
        //        {
        //            output *= x;
        //        }
        //        output = 1 / output;
        //    }

        //    return output;
        //}

        //public double MyPow(double x, int n)
        //{

        //    return Math.Pow(x,n);
        //}
       
        public double MyPow(double x, int n)
        {
            if (n < 0) return 1 / MyPow(x, n * -1);

            if (n == 0) return 1;
            if(n == 1) return x;

            if(n%2 == 1)
            {
                return x * MyPow(x,n-1);
            }
            double val = MyPow(x, n/2);
            return val*val;

        }
    }
}
