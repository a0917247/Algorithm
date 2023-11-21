using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    public class InsertionSort
    {
        //插入排序法
        // 0 ~ 0 有序
        // 0 ~ N 有序
        public void Insertionsort(int[] arr) 
        {
            if (arr == null || arr.Length < 2) 
            {
                return;
            }

            for (int i = 1; i < arr.Length; i++) 
            {
                for (int j = i; j > 0 && arr[j] >= arr[j-1]; j--) 
                {
                    if (arr[j] > arr[j - 1]) 
                    {
                        Swap(arr,j,j-1);
                    }
                }
            }
            Print(arr);
        }
        public static void Swap(int[] arr, int i , int j) 
        {
            arr[i] = arr[j] ^ arr[i];
            arr[j] = arr[j] ^ arr[i];
            arr[i] = arr[j] ^ arr[i];
        }
        public static void Print(int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
