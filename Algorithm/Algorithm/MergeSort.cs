using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class MergeSort
    {
        public void Mergesort(int[] arr)
        {
            if (arr == null || arr.Length < 2)
            {
                return;
            }
            Sort(arr, 0, arr.Length - 1);
        }

        public void Sort(int[] arr, int L, int R)
        {
            if (L == R)
            {
                return;
            }
            int mid = L + ((R - L) >> 1);
            Sort(arr, L, mid);
            Sort(arr, mid + 1, R);
            Merge(arr, L, mid, R);
        }

        public static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] help = new int[right - left + 1];
            int p1 = left;
            int p2 = mid + 1;
            int i = 0;
            while (p1 <= mid && p2 <= right)
            {
                help[i++] = arr[p1] <= arr[p2] ? arr[p1++] : arr[p2++];
            }
            while (p1 <= mid)
            {
                help[i++] = arr[p1++];
            }
            while (p2 <= right)
            {
                help[i++] = arr[p2++];
            }

            for (i = 0; i < help.Length; i++)
            {
                arr[left + i] = help[i];
            }
        }

    }
}
