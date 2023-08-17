using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    public class Code1_SelectionSort
    {
        //選擇排序法
        //1.有兩個不同的指針，一個指針指向當前index，另一個指針指向最小值，將最小值index與i對換
        public void SelectionSort(int[] arr) 
        {
            if (arr.Length < 2 || arr == null) {
                return;
            }
            for (int i = 0; i < arr.Length - 1; i++) {
                int minindex = i;
                for (int j = i + 1; j < arr.Length; j++) 
                {
                    minindex = arr[minindex] > arr[j] ? j : minindex;
                }
                swap(arr, i, minindex);
            }
            PrintArray(arr);
        }

        public static void swap(int[] arr, int i, int j) 
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.Write(arr[i]);
            }
        }
    }
}
