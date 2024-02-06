using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.LeetCode
{
    public class Code09_PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x == null || x < 0)
            {
                return false;
            }

            string a = x.ToString();
            int mid = a.Length >> 1;
            int start = 0;
            while (start != mid)
            {
                if (a[start] != a[a.Length - 1 - start])
                {
                    return false;
                }
                start++;
            }
            return true;
        }
    }
}
