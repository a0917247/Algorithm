﻿using Algorithm.Extension;

namespace algorithm;
public class Program
{
    static void Main(string[] args)
    {
        Code1_SelectionSort code = new Code1_SelectionSort();
        int[] ints = { 2, 4, 2, 1, 5, 4, 6, 5, 6 };
        int[] twoInt = { 2, 4, 2, 1, 5, 4, 6, 5, 6, 2 };
        int TestTime = 1000000;
        int maxSize = 100;
        bool Success = true;
        for (int i = 0; i < TestTime; i++)
        {
            int[] arr1 = RandomArray(maxSize);
            int[] arr2 = arr1.CopyArray();
            code.SelectionSort(arr1);
            comparator(arr2);
            if (!arr1.Equal(arr2))
            {
                Success = false;
                break;
            }
        }
        Console.WriteLine(Success ? "測試成功" : "測試有誤");
        if (!Success)
        {
            int[] arr = RandomArray(maxSize);
            Print(arr);
            code.SelectionSort(arr);
            Print(arr);
        }
    }
    public static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    public static int[] RandomArray(int maxSize)
    {
        Random r = new Random();
        int[] ints = new int[maxSize];
        for (int i = 0; i < ints.Length; i++)
        {
            ints[i] = r.Next() - r.Next() - 1;
        }
        return ints;
    }

    public static void comparator(int[] arr)
    {
        Array.Sort(arr);
    }
}