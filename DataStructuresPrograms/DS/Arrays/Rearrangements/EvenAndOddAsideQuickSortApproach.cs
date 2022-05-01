using DataStructuresPrograms.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class EvenAndOddAsideQuickSortApproach
    {
        public EvenAndOddAsideQuickSortApproach(int[] arr)
        {
            QuickSolver(arr);
        }

        /// <summary>
        /// 
        /// just same as quick sort algorithm, but we have to change only the if condition.
        /// here we loose the order of numbers.
        /// 
        /// </summary>
        /// <param name="arr"></param>
        static void QuickSolver(int[] arr)
        {
            int n = arr.Length-1;
            int iterator = -1;

            for(int i = 0; i < n; i++)
            {
                if ((arr[i] & 1) == 0)
                    arr.Swap(++iterator,i);
            }
            arr.Swap(++iterator, n);
        }
    }
}
