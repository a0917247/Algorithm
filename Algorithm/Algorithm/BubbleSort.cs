using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    public class BubbleSort
    {
        //i跟i++比較，誰大誰往右移
        //0 ~ 5 排序
        //0 ~ 4 排序
        public void Bubblesort2(int[] arr)
        {
            if (arr.Length < 2 || arr == null)
            {
                return;
            }
            for (int i = arr.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swap(arr, j, j + 1);
                    }
                }
            }
            Print(arr);
        }
        public void Bubblsort(int[] arr)
        {
            if (arr.Length < 2 || arr == null)
            {
                return;
            }

            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        swap(arr, i, j);
                    }
                }
            }
            Print(arr);
        }

        public static void swap(int[] arr, int i, int j)
        {
            // ^抑或運算ㄌ
            arr[i] = arr[i] ^ arr[j];
            arr[j] = arr[i] ^ arr[j];
            arr[i] = arr[i] ^ arr[j];
        }

        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
