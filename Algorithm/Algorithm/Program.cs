using Algorithm;
using Algorithm.Extension;

namespace algorithm;
public class Program
{
    // 排序法
    //static void Main(string[] args)
    //{
    //    int[] ints = { 1, 4, 0, 1, 9, 66, 7 };
    //    int[] twoInt = { 2, 4, 2, 1, 5, 4, 6, 5, 6, 2 };
    //    MergeSort code = new MergeSort();
    //    //SelectionSort code = new SelectionSort();
    //    //int TestTime = 1000000;
    //    //int maxSize = 100;
    //    //bool Success = true;
    //    //for (int i = 0; i < TestTime; i++)
    //    //{
    //    //    int[] arr1 = RandomArray(maxSize);
    //    //    int[] arr2 = arr1.CopyArray();
    //    //    code.Selectionsort(arr1);
    //    //    comparator(arr2);
    //    //    if (!arr1.Equal(arr2))
    //    //    {
    //    //        Success = false;
    //    //        break;
    //    //    }
    //    //}
    //    //Console.WriteLine(Success ? "測試成功" : "測試有誤");
    //    //if (!Success)
    //    //{
    //    //    int[] arr = RandomArray(maxSize);
    //    //    Print(arr);
    //    //    code.Selectionsort(arr);
    //    //    Print(arr);
    //    //}
    //}
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

    static void Main(string[] args) 
    {
        BinaryTree binarytree = new BinaryTree();
        binarytree.Root = new TreeNode(null);
        Console.WriteLine(binarytree.Root.Value);
        binarytree.Print();
    }
}