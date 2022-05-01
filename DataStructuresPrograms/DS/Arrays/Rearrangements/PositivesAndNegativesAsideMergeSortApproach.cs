using DataStructuresPrograms.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class PositivesAndNegativesAsideMergeSortApproach
    {
        public PositivesAndNegativesAsideMergeSortApproach(int[] arr)
        {
            //QuickSolve(arr);
            MergeSolve(arr);
        }

        /// <summary>
        /// we are taking a pointer to rotate the array and a pointer to swap the negative numbers to left.
        /// we dont loose the order of elements
        /// 
        /// </summary>
        /// <param name="arr"></param>
        static void QuickSolve(int[] arr)
        {
            int pivot = 0;
            int smallerElementIndex = -1;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < pivot)
                {
                    arr.Swap(++smallerElementIndex, i);
                }
            }
        }

        static void MergeSolve(int[] arr)
        {
            MergeSolve(arr,0,arr.Length-1);
        }

        /// <summary>
        /// 
        /// devide the array into two parts over mid, and hope the actual action is executed by Merge function perfectly.
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        static void MergeSolve(int[] arr,int start,int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                MergeSolve(arr,start,mid);
                MergeSolve(arr,mid+1,end);
                Merge(arr,start,mid,end);
            }
        }

        /// <summary>
        /// 
        /// it is a replicate of merge of mergesort.
        /// 
        /// in the least level the array may have 1 or 2 elements in the limit of start and end.
        /// if 1 element, then start and end nothing will happen here
        /// if 2 elements then 
        ///         [4, -3] if array elements are like this, then
        ///                 at first start=0, end=1, mid=0
        ///                 left=0, right=1
        ///                 left will come out of loop as first element is not less than 0, and left=0
        ///                 right will come out of loop in second iteration as it reaches end, right=2
        ///                 
        ///                 rotate arr from (left,mid) i.e, (0,0)=> nothing changes 
        ///                 rotate arr from (mid+1,right-1) i.e, (1,1) => nothing changes
        ///                 rotate arr from (left,right-1) i.e, (0,1) => array becomes [-3,4]
        ///         
        ///         [-3,4] then left=1,mid=0,right =1 after looping. rotate will work only when start is less than end
        ///                 rotate (left,mid)      i.e, (1,0) => don't work 
        ///                 rotate (mid+1,right-1) i.e, (1,0) => don't work
        ///                 rotate (left,right-1)  i.e, (1,0) => don't work
        ///         
        ///         [4,5] => left =0, mid=1, right=1 as both will come out of loop in the first iteration itself then,
        ///                 rotate (left,mid)      i.e, (0,0) => nothing changes 
        ///                 rotate (mid+1,right-1) i.e, (1,1) => nothing changes
        ///                 rotate (left,right-1)  i.e, (0,0) => nothing changes
        ///         
        ///         [-1,-2] => left=1, mid=0, right=2, as both will have one iteration. 
        ///                 rotate (left,mid)      i.e, (1,0) => don't work 
        ///                 rotate (mid+1,right-1) i.e, (1,1) => nothing changes
        ///                 rotate (left,right-1)  i.e, (1,1) => nothing changes
        /// 
        /// finally array is like negatives on the left side and non-negatives are on the right side. and merge will be work for higher elements.
        /// 
        /// at the end of loops, left and right will always points to first non-negative element [sometimes right points to end+1 index, if no right present]
        /// 
        /// [-L1, -L2, -L3, +L4, +L5, +L6, -R1, -R2, -R3, +R4, +R5, +R6]
        ///                 left      mid                 right
        /// 
        /// now take array from left to right-1
        ///         [+L4, +L5, +L6, -R1, -R2, -R3]
        ///         left       mid            right-1
        /// 
        /// 
        /// after rotate from (left,mid)
        ///         [+L6, +L5, +L4, -R1, -R2, -R3]
        ///         left       mid            right-1
        /// 
        /// after rotate from (mid+1,right-1)
        ///         [+L6, +L5, +L4, -R3, -R2, -R1] 
        ///         left       mid            right-1
        ///
        ///  after rotate from (left,right-1)
        ///         [-R1, -R2, -R3, +L4, +L5, +L6]
        ///         left       mid            right-1
        ///         
        /// so the is not lost, and they got rotated.
        /// 
        /// 
        /// 
        /// Time  Complexity:- O(nlogn)
        /// Space Complexity:- O(logn) => for the stack of recursion.
        /// 
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="mid"></param>
        /// <param name="end"></param>
        static void Merge(int[] arr,int start, int mid,int end)
        {
            int left = start;
            int right = mid + 1; //initialisation

            //action that has to be done.
            //take the first non-negative element 
            while (left <= mid && arr[left] < 0)
                left++;

            //take first non-negative element
            while (right <= end && arr[right] < 0)
                right++;


            arr.Reverse(left,mid);
            arr.Reverse(mid + 1,right-1);
            arr.Reverse(left,right-1);
        }
    }
}
