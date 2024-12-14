using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202.HappyNummber
{
    public class Solution
    {
        //public bool IsHappy(int n, Dictionary<int, int> memo = null)
        //{
        //    if(memo == null)
        //        memo = new Dictionary<int, int>();
        //    if(n == 1)
        //    {
        //        return true;
        //    }
        //    if(memo.ContainsKey(n))
        //    {
        //        return false;
        //    }

        //    string s = n.ToString();
        //    int m = 0;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        int a = Convert.ToInt32(s[i].ToString());
        //        m += a * a;
        //    }
        //    memo[n] = m;
        //    return IsHappy(m, memo);

        //}

        public bool IsHappy(int n, List<int> memo = null)
        {
            if (memo == null)
                memo = new List<int>();
            if (n == 1)
            {
                return true;
            }
            if (memo.Contains(n))
            {
                return false;
            }

            string s = n.ToString();
            int m = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int a = Convert.ToInt32(s[i].ToString());
                m += a * a;
            }
            memo.Add(n);
            return IsHappy(m, memo);

        }


        //if (m == 1)
        //{
        //    return IsHappy(m, memo);
        //}
        //else
        //{


        //    memo[n] = m;
        //    IsHappy(m, memo);
        //}

    }
}
