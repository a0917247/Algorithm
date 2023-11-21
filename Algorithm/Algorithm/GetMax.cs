using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class GetMax
    {
        public int Getmax(int[] arr) 
        {
            return Process(arr, 0, arr.Length - 1);
        }

        public static int Process(int[] arr,int l, int r) 
        {
            if (l == r) 
            {
                return arr[l];
            }
            int middle = l + ((r - l)>> 1);
            int left = Process(arr,l,middle);
            int right = Process(arr,middle + 1, r);
            return Math.Max(left, right);
        }
    }
}
