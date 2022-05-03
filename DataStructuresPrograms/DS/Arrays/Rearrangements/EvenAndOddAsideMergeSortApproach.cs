using DataStructuresPrograms.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class EvenAndOddAsideMergeSortApproach
    {
        public EvenAndOddAsideMergeSortApproach(int[] arr)
        {
            EvenAndOddAsideSolver(arr);
        }

        public void EvenAndOddAsideSolver(int[] arr)
        {
            EvenAndOddAsideSolver(arr,0,arr.Length-1);
        }

        public void EvenAndOddAsideSolver(int[] arr,int start,int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                EvenAndOddAsideSolver(arr,start,mid);
                EvenAndOddAsideSolver(arr,mid+1,end);
                EvenAndOddAsideSolvingApproach(arr,start,mid,end);
            }
        }

        public void EvenAndOddAsideSolvingApproach(int[] arr,int start,int mid,int end)
        {
            int left = start,right=mid+1;

            while (left <= mid && (arr[left] & 1) == 0)
                left++;

            while (right <= end && (arr[right] & 1) == 0)
                right++;


            arr.Reverse(left,mid);
            arr.Reverse(mid+1,right-1);
            arr.Reverse(left,right-1);

        }


    }
}
