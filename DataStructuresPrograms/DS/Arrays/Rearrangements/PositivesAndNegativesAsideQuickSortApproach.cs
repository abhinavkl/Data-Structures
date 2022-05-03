using DataStructuresPrograms.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class PositivesAndNegativesAsideQuickSortApproach
    {

        public PositivesAndNegativesAsideQuickSortApproach(int[] arr)
        {
            QuickSolve(arr);
        }

        /// <summary>
        /// we are taking a pointer to rotate the array and a pointer to swap the negative numbers to left.
        /// we loose the order of elements
        /// 
        /// </summary>
        /// <param name="arr"></param>
        static void QuickSolve(int[] arr)
        {
            int pivot = 0;
            int smallerElementIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < pivot)
                {
                    arr.Swap(++smallerElementIndex, i);
                }
            }
        }
    }

}
