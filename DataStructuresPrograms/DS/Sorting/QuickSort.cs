using DataStructuresPrograms.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Sorting
{
    internal class QuickSort
    {
        /// <summary>
        /// 
        /// at first we take an array and have [start] and [end] of the array.
        /// we take the last element as pivot.
        /// use a pointer for SmallerElements, and move every smaller elements to one side by swapping.
        /// once the loop completed, all the smaller elements are already at one side and larger elements are one side.
        /// now as we taken pivot which is the last element, replace [smallElements+1] to end and end to [smallerElements+1]
        /// and return the pivot position as to say that position is solved.
        /// 
        /// Apply above algorithm over array between start and pivot-1, and pivot+1 and end.
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public QuickSort(int[] arr)
        {
            QuickSorter(arr);
        }

        static void QuickSorter(int[] arr)
        {
            QuickSorter(arr,0,arr.Length-1);
        }

        static void QuickSorter(int[] arr,int start,int end)
        {
            if (start >= end)
                return;

            int pivot = NextPivot(arr,start,end);
            QuickSorter(arr,start,pivot-1);
            QuickSorter(arr,pivot+1,end);
        }

        static int NextPivot(int[] arr,int start,int end)
        {
            int pivot = arr[end];
            int pivotActualPosition = start - 1;
            for(int i = start; i < end; i++)
            {
                if (arr[i] < pivot)
                    arr.Swap(++pivotActualPosition,i);
            }
            arr.Swap(++pivotActualPosition,end);

            return pivotActualPosition;
        }

    }
}
