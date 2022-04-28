using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class ReverseArray
    {
        /// <summary>
        /// 
        /// swap
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public ReverseArray(int[] arr)
        {
            int n = arr.Length - 1;
            //IterativeReverse(arr,0,n);
            arr=RecursiveReverse(arr,0,n);
        }

        static void IterativeReverse(int[] arr,int start,int end)
        {
            while (start <= end)
            {
                if (arr[start] != arr[end])
                {
                    arr[start] = arr[start] ^ arr[end];
                    arr[end] = arr[start] ^ arr[end];
                    arr[start] = arr[start] ^ arr[end];
                }
                start++;end--;
            }
        }

        static int[] RecursiveReverse(int[] arr, int start, int end)
        {
            if (start > end)
                return arr;
            if (arr[start] != arr[end])
            {
                arr[start] = arr[start] ^ arr[end];
                arr[end] = arr[start] ^ arr[end];
                arr[start] = arr[start] ^ arr[end];
            }
            return RecursiveReverse(arr,++start,--end);
        }


    }
}
