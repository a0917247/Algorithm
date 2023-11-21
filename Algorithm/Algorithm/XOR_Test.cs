using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    public class XOR_Test
    {
        // 重複陣列中找到不重複的數
        public void XOR(int[] arr) 
        {
            int XOR = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                XOR ^= arr[i];
            }
            Console.WriteLine(XOR);
        }

        //陣列中找到兩個不重複的數
        public void OddTimesNum2(int[] arr) 
        {
            int xor = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                xor ^= arr[i];
            }
            // 取得最右側的1
            int oneNum = xor & (~xor + 1);
            for (int i = 0; i < arr.Length; i++) 
            {
                if ((oneNum & arr[i]) == 0) 
                {
                    oneNum ^= arr[i];
                }
            }
            Console.WriteLine($"{oneNum},{xor ^ oneNum}");
        }
    }
}
