using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Order
{
    internal class KthSmallestIn2DSortedArray
    {
        public KthSmallestIn2DSortedArray(int[,] arr,int k)
        {
            int pos = 0;
            if(k<=arr.GetLength(0))
            {
                for (int i = 1; i < k; i++)
                {
                    if (arr[i - 1, k - i] < arr[i, 0])
                        pos += k - i;
                    Console.WriteLine(arr[i-1,k-i]);
                }
            }
        }
    }
}
