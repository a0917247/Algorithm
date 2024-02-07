using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.LeetCode
{
    public class Code66_PlusOne
    {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i > -1; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            // 只有全部的位數都是 9 的情況才會跑完迴圈，故只要將第一位變成 1 就好
            int[] result = new int[digits.Length + 1];
            result[0] = 1;

            return result;

        }
    }
}
