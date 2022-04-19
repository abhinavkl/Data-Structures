using DataStructuresPrograms.Code.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rotations
{
    internal class FindMinimumElement
    {
        /// <summary>
        /// Find the largest element index and add 1 to it and get the arr element for that index.
        /// </summary>
        /// <param name="arr"></param>
        public FindMinimumElement(int[] arr)
        {
            int soln=SolveSolution(arr);
            PrintObject.Print(arr[soln+1]);
        }
        public int SolveSolution(int[] arr)
        {
            if (arr[0] < arr[arr.Length - 1])
                return -1;
            else return SolveSolution(arr,0,arr.Length-1);
        }
        public int SolveSolution(int[] arr,int start,int end)
        {
            if (start > end)
                return -1;
            if (start == end)
                return start;
            int mid = (start + end) / 2;

            if (arr[start] < arr[mid])
                return SolveSolution(arr, mid, end);
            else return SolveSolution(arr, start, mid);
        }
    }
}
