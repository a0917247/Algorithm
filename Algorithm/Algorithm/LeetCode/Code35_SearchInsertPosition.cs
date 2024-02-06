using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.LeetCode
{
    public class Code35_SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums == null)
            {
                return -1;
            }
            int l = 0;
            int r = nums.Length - 1;
            while (l < r)
            {
                int mid = (l + r) >> 1;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[mid] > target)
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return nums[l] < target ? ++l : l;
        }
    }
}
