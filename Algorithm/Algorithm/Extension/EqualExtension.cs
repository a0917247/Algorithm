using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Extension
{
    public static class Extension
    {
        #region Equal,測試兩個陣列的值是否相等
        public static bool Equal(this int[] arr1, int[] arr2) 
        {
            if (arr1.Length != arr2.Length || arr1 == null || arr2 == null) 
            {
                return false;
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    continue;
                }
                else 
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
        #region CopyArray,複製陣列
        public static int[] CopyArray(this int[] arr)
        {
            if (arr == null)
            {
                return arr;
            }
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++) 
            {
                result[i] = arr[i];
            }
            return result;
        }
        #endregion
    }
}
