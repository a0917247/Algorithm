using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.LeetCode
{
    public class Code14_LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string result = string.Empty;
            if (strs == null)
            {
                return result;
            }
            int defaultlen = strs[0].Length;
            for (int i = 0; i < defaultlen; i++)
            {
                char curChar = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j].Length <= i || curChar != strs[j][i])
                    {
                        return result;
                    }
                }
                result += curChar;
            }
            return result;
        }
    }
}
