using DataStructuresPrograms.Code.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rotations
{
    internal class FindPairInSortedRotateArray
    {
        /// <summary>
        /// Space complexity : O(1), time complexity : O(n)
        /// First find pivot which is the largest element index
        /// Now take left as pivot index, and right as pivot+1 index
        /// start counter as 0
        /// 
        ///if arr[left]+arr[right] = (required-sum) then increase the counter and increase right index and decrease left index (take mod by arr.length)
        ///if arr[left] + arr[right] < (required-sum) then increase the right index
        ///if arr[left] + arr[right] > (required-sum) then decrease the left index
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sum"></param>

        public FindPairInSortedRotateArray(int[] arr, int sum)
        {
            int pivot = LargestElementIndex(arr);

            int right = pivot;
            int left = (pivot + 1) % arr.Length;

            int counter = 0;

            while (left!=right)
            {
                if (arr[left] + arr[right] == sum)
                {
                    counter++;
                    if (left == right - 1)
                        break;
                    left = (left + 1) % arr.Length;
                    right = (right - 1) % arr.Length;
                }
                else if (arr[left] + arr[right] < sum)
                    left = (left + 1) % arr.Length;
                else right = (right - 1) % arr.Length;
            }
            PrintObject.Print(counter);
        }

        public int LargestElementIndex(int[] arr, int start, int end)
        {
            if (start > end)
                return -1;
            if (start == end)
                return start;
            int mid = (start + end) / 2;
            if (arr[start] < arr[mid])
                return LargestElementIndex(arr, mid, end);
            else return LargestElementIndex(arr, start, mid);
        }
        public int LargestElementIndex(int[] arr)
        {
            return LargestElementIndex(arr, 0, arr.Length);
        }

    }
}
