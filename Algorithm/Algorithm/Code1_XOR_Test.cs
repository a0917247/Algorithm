using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    public class Code1_XOR_Test
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
    }
}
