using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Algorithm.LeetCode
{
    public class Code28_FindtheIndexoftheFirstOccurrenceInAString
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle == null || needle == string.Empty)
            {
                return -1;
            }
            if (needle.Length > haystack.Length)
            {
                return -1;
            }
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
