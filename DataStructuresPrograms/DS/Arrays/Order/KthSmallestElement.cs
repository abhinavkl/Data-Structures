using DataStructuresPrograms.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Order
{
    internal class KthSmallestElement
    {
        public KthSmallestElement(int[] arr,int k)
        {
            Solver(arr,k);
        }

        /// <summary>
        /// 
        /// at first we have to make elements in such a way that,
        /// 
        ///                     a1
        ///            a2               a3
        ///     a4          a5    a6           a7
        ///     
        /// where a1 is min(a1,a2,a3) and a2 is min(a2,a4,a5) ....
        /// so we get a1 as the min of all, while a2 may or may not the second minimum. but it is smaller than its right and left.
        /// 
        /// each time we heapify the array from here we get the minimum element to the 0th position. Where the minimum is in range of 0 to lastElementIndex
        /// 
        /// as we are using heapify where the second arg.=> the highest index of the considerable array, once we find the minimum we move it to the last index,
        /// and we reduce the considerable array last element index. And in this way we get the second, third and ... minimum elements and we move them to second, third ... last indexes.
        /// 
        /// as we get kth smallest element, we stop once the 'j' becomes k. 
        /// 
        /// </summary>
        /// <param name="arr"></param>
        static int Solver(int[] arr,int k)
        {
            return FindKthSmallestElement(arr,k);
        }


        static int FindKthSmallestElement(int[] arr,int k)
        {
            for(int i = arr.Length/2-1; i >= 0; i--)
            {
                Heapify(arr,arr.Length,i);
            }

            for(int i = arr.Length - 1,j=0; i >= 0 && j<k; i--,j++)
            {
                arr.Swap(i,0);
                Heapify(arr,i,0);
            }

            return arr[arr.Length-k+1];
        }

        //arr, where should the value go, which value
        static void Heapify(int[] arr,int lastElementIndex, int pos)
        {
            int left = 2 * pos + 1;
            int right = 2 * pos + 2;

            int min = pos;

            if (left < lastElementIndex && arr[left] < arr[min])
                min = left;
            if (right < lastElementIndex && arr[right] < arr[min])
                min = right;

            if (min != pos)
            {
                arr.Swap(min,pos);
                Heapify(arr, lastElementIndex, min);
            }

        }


    }
}
