
using DataStructuresPrograms.Code.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rotations
{
    internal class RotationCount
    {
        /// <summary>
        /// it is just finding the max element index
        /// 
        /// find mid, for start and end => if a[start] < a[mid] => then the highest element will be in mid to end 
        /// else it will be in start to end
        /// 
        /// on every iteration start and end come closer, if they are equal return that index value.
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public RotationCount(int[] arr)
        {
            PrintObject.Print(arr[0]<arr[arr.Length-1]?0:FindMaxIndex(arr,0,arr.Length-1));
        }

        public int FindMaxIndex(int[] arr,int start,int end)
        {
            if (start > end)
                return 0;
            if (start == end)
                return start;
            int mid = (start + end) / 2;
            if (arr[start] < arr[mid])
                return FindMaxIndex(arr, mid,end);
            else return FindMaxIndex(arr,start,mid);
        }

    }
}
