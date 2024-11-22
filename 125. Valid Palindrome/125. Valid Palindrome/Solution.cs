using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _125._Valid_Palindrome
{
    public class Solution
    {

        public bool IsPalindrome(string s)
        {
            int x = 0, y = s.Length - 1;

            while (x <= y)
            {
                char a = s[x]; char b = s[y];
                if (!char.IsLetterOrDigit(a))
                {
                    x++;
                }
                else if (!char.IsLetterOrDigit(b))
                {
                    y--;
                }
                else
                {
                    if (char.ToLower(a) != char.ToLower(b))
                        return false;
                    x++; y--;
                }


            }
            return true;

        }


        // With Regex

        public bool PainDromeCheck(string s, int i, int j)
        {
            if (i >= j) return true;
            if(s[i] != s[j]) return false;
            i++; j--;
            return PainDromeCheck(s, i, j);
            

        }

        public bool IsPalindromeWithRegex(string s)
        {
            s = Regex.Replace(s, "[^A-Za-z0-9]", "");

            s = s.ToLower();

            int x = 0, y = s.Length - 1;

            return PainDromeCheck(s, x, y);

        }
        //public bool IsPalindrome(string s)
        //{
        //    s = Regex.Replace(s, "[^A-Za-z0-9]", "");

        //    s = s.ToLower();

        //    int x = 0, y = s.Length - 1;

        //    while (x <= y)
        //    {
        //        char a = s[x], b = s[y];
        //        if (a !=b)
        //        {
        //            return false;
        //        }
        //        x++; y--;
        //    }
        //    return true;

        //}





    }
}
