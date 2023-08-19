namespace algorithm;
public class Program
{
    static void Main(string[] args)
    {
        int[] ints = { 2, 4, 2, 1, 5, 4, 6, 5, 6 };
        int[] twoInt = { 2, 4, 2, 1, 5, 4, 6, 5, 6 , 2};
        int[] testarr = { 2, 5, 1, 6, 9, 0, 8, 7 };
        Code1_XOR_Test code = new Code1_XOR_Test();
        code.OddTimesNum2(twoInt);
    }
    public static int[] RandomArray()
    {
        Random r = new Random();
        int[] ints = new int[r.Next(10000)];
        for (int i = 0; i < ints.Length; i++)
        {
            ints[i] = r.Next();
        }
        return ints;
    }
    public static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}