using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algorithm.LeetCode
{
    public class Code58_LengthofLastWord
    {
        public int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s)) 
            {
                return 0;
            }
            s = s.Trim();
            string[] sa = s.Split(' ');
            char[] ca = sa[sa.Length - 1].ToCharArray();
            return ca.Length;
        }
    }
}
