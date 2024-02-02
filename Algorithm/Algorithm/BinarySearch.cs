using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class BinarySearch
    {
        private int[] Arr {  get; set; }

        public BinarySearch(int[] arr) 
        {
            Arr = arr;
        }

        public int BS(int target) 
        {
            if (Arr == null)
            {
                return -1;
            }

            Array.Sort(Arr);
            int left = 0;
            int right = Arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) >> 1; // (left + right) / 2

                if (Arr[mid] == target)
                {
                    //Console.WriteLine($"{mid}");
                    return mid;
                }

                if (Arr[mid] > target)
                {
                    right = mid - 1;
                }
                if (Arr[mid] < target)
                {
                    left = mid + 1;
                }
            }
            //Console.WriteLine("沒有");
            return -1;
        }
    }
}
