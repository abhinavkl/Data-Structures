using DataStructuresPrograms.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class ReorderAnArrayWithGivenIndices
    {
        /// <summary>
        /// 
        /// if both array have same length, and ind[] have all positive indices and btw 0 to ind.Length-1
        /// 
        /// loop through 0 to n (array length)
        /// if ind[i]!= i then 
        ///     1. Swap array elements of (i,ind[i])
        ///     2. Swap ind   elements of (i,ind[i])
        ///     
        ///     must use the steps 1 & 2 in the given order, otherwise once the 2nd step is done first and then the ind[] elements do change, and i=ind[i].
        /// 
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="ind"></param>
        public ReorderAnArrayWithGivenIndices(int[] arr,int[] ind)
        {
            if (arr.Length == ind.Length && !ind.Any(i=> i<0 || i>=ind.Length)) //both should have same length, and ind should have all positive indices and btw 0 to ind.Length-1
            {
                Solver(arr,ind);
            }
        }

        static void Solver(int[] arr,int[] ind)
        {
            int n = arr.Length;
            for(int i = 0; i < n; i++)
            {
                if (ind[i] != i)
                {
                    arr.Swap(i, ind[i]);
                    ind.Swap(i,ind[i]);
                }
            }
        }
    }
}
