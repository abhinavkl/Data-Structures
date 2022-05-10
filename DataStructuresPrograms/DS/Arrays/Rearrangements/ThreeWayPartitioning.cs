using DataStructuresPrograms.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class ThreeWayPartitioning
    {
        public ThreeWayPartitioning(int[] arr,int lowerBound,int upperBound)
        {
            Solver(arr,lowerBound,upperBound);
        }

        /// <summary>
        /// 
        /// start with 0, and
        ///     if the curr element is less than lower limit, then replace to left side (everytime we replace we know that left side element is always less than lower limit, so increment curr)
        ///     if the curr element is grtr than highr limit, then replace to rigt side (everytime we replace we dn't know whether right side element is in correct bound, so we don't increase curr)
        ///     so we iterate till right, and right to end are already swapped so, these positions are arranged.
        ///     
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lowerBound"></param>
        /// <param name="upperBound"></param>
        static void Solver(int[] arr, int lowerBound, int upperBound)
        {
            int left = 0;
            int right = arr.Length - 1;

            for (int i = 0; i < right;)
            {
                if (arr[i] < lowerBound)
                    arr.Swap(i++, left++);
                else if (arr[i] > upperBound)
                    arr.Swap(i, right--);
                else i++;
            }
        }
    }
}
