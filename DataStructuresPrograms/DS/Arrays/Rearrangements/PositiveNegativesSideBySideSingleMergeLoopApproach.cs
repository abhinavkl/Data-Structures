using DataStructuresPrograms.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class PositiveNegativesSideBySideSingleMergeLoopApproach
    {
        //positives at even index and negatives at odd index, single merge loop.
        public PositiveNegativesSideBySideSingleMergeLoopApproach(int[] arr)
        {
            Solver(arr);
        }

        /// <summary>
        /// 
        /// first initiate [positive]=0, [negative]=1
        /// go through loop,
        /// 
        /// take first misplaced positive element index, and negative element index
        /// only if both of them exists swap, else come out of loop.
        /// 
        /// Time  Complexity:- O(n)
        /// Space complexity:- O(1)
        /// 
        /// </summary>
        /// <param name="arr"></param>
        static void Solver(int[] arr)
        {
            int n = arr.Length - 1;
            int positive = 0, negative = 1;

            while (true)
            {
                while (positive <= n && arr[positive] >= 0)
                    positive += 2;

                while (negative <= n && arr[negative] <= 0)
                    negative += 2;

                if (positive <= n && negative <= n)
                    arr.Swap(positive, negative);
                else break;
            }


        }

    }
}
