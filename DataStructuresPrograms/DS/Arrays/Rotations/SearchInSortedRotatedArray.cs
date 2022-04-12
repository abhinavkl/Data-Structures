using DataStructuresPrograms.Code.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rotations
{
    internal class SearchInSortedRotatedArray
    {
        /// <summary>
        /// 
        /// first find the place where elements are rotated.
        /// binary search over those two parts.
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="search"></param>
        public SearchInSortedRotatedArray(int[] arr, int search)
        {
            int pivot = Pivot(arr, 0, arr.Length - 1);
            int sol = 0;
            if (arr[0] <= search && arr[pivot] >= search)
                sol = BinarySearch(arr, search, 0, pivot);
            else
                sol = BinarySearch(arr,search,pivot+1,arr.Length-1);
            PrintObject.Print(sol);
        }

        static int BinarySearch(int[] arr,int search,int start,int end)
        {
            if (start > end)
                return -1;
            int mid = (start + end) / 2;
            if (arr[mid] == search)
                return mid;
            if (arr[mid] > search)
                return BinarySearch(arr, search, start, mid);
            else return BinarySearch(arr, search, mid + 1, end);
        }

        static int Pivot(int[] arr,int start,int end)
        {
            if (start > end) return -1;
            if (start == end)
                return start;
            int mid = (start + end) / 2;
            if (arr[start] < arr[mid])
                return Pivot(arr, mid, end);
            else return Pivot(arr,start,mid);
        }
    }
}