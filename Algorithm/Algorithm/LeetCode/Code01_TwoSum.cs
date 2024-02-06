using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.LeetCode
{
    public class Code01_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums == null)
            {
                return null;
            }
            // 用hashmap 對應，key = target - nums[i], value = index;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int num = target - nums[i];
                if (dic.ContainsKey(num))
                {
                    return new int[] { dic[num], i };
                }
                dic[nums[i]] = i;
            }
            return null;
        }
    }
}
