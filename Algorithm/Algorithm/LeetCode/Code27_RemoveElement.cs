using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.LeetCode
{
    public class Code27_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int cur = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[cur] = nums[i];
                    cur++;
                }
            }
            return cur;
        }
    }
}
