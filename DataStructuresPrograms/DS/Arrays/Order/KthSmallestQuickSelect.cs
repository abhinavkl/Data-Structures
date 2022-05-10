using DataStructuresPrograms.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Order
{
    internal class KthSmallestQuickSelect
    {
        public KthSmallestQuickSelect(int[] arr,int k)
        {
            Solve(arr, k);
        }

        /// <summary>
        /// 
        /// first take end as the pivot, and get the pivot index, and if the index is greater then quickify on the left side, else quickify on right side.
        /// if pivot index is the required index, then stop
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        static int Solve(int[] arr,int k)
        {
            FindKthSmallestQuickSelect(arr,k,0,arr.Length-1);
            return arr[k-1];
        }

        static void FindKthSmallestQuickSelect(int[] arr,int k,int start,int end)
        {

            if (start < end)
            {
                int pivotIndex = GetPivot(arr,start,end);

                if (pivotIndex < k)
                    FindKthSmallestQuickSelect(arr, k, pivotIndex + 1, end);
                else if(pivotIndex > k)
                    FindKthSmallestQuickSelect(arr,k,start, pivotIndex - 1);

            }

        }


        static int GetPivot(int[] arr,int start,int end)
        {
            int pivot = arr[end];
            int iterator = start - 1;


            for(int i = start; i <= end; i++)
            {
                if (arr[i] < pivot)
                    arr.Swap(++iterator,i);
            }
            arr.Swap(++iterator,end);
            return iterator;

        }



    }
}
