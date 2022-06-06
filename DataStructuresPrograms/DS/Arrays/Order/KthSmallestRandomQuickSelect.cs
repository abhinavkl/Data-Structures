using DataStructuresPrograms.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Order
{
    internal class KthSmallestRandomQuickSelect
    {
        public KthSmallestRandomQuickSelect(int[] arr,int k)
        {
            Solver(arr,k);
        }

        /// <summary>
        /// 
        /// we are using a random index btw start and end, and change the index to end. pivot is not the last element
        /// first take end as the pivot, and get the pivot index, and if the index is greater then quickify on the left side, else quickify on right side.
        /// if pivot index is the required index, then stop
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        static int Solver(int[] arr,int k)
        {
            FindKthSmallestRandomQuickSelect(arr,k,0,arr.Length-1);
            return arr[k-1];
        }

        static void FindKthSmallestRandomQuickSelect(int[] arr,int k,int start,int end)
        {
            if (start < end)
            {
                int pivotIndex = GetPivotUsingRandomQuickSelector(arr,start,end);
                if (pivotIndex < k)
                    FindKthSmallestRandomQuickSelect(arr, k, pivotIndex + 1, end);
                else if (pivotIndex > k)
                    FindKthSmallestRandomQuickSelect(arr,k,start,pivotIndex-1);
            }
        }

        static int GetPivotUsingRandomQuickSelector(int[] arr,int start,int end)
        {
            int n = end - start + 1;
            int pivot = new Random().Next(n);
            arr.Swap(start+pivot,end);
            return GetPivot(arr,start,end);
        }

        static int GetPivot(int[] arr,int start,int end)
        {
            int pivot = arr[end];
            int iterator = start - 1;

            for(int i = start;i <= end; i++){
                if (arr[i] < pivot)
                    arr.Swap(++iterator,i);
            }
            arr.Swap(++iterator,end);
            return iterator; 
        }
    }
}
