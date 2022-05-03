using DataStructuresPrograms.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class EvenAndOddSideBySideAingleMergeLoopApproach
    {
        public EvenAndOddSideBySideAingleMergeLoopApproach(int[] arr)
        {
            //Solver(arr);
        }


        /// <summary>
        /// 
        /// it is a single loop mergesort approach, where we use two pointers and once conditions fail for both of them then swap else return.
        /// here also we will loose the order of numbers.
        /// 
        /// </summary>
        /// <param name="arr"></param>
        static void Solver(int[] arr)
        {
            int n = arr.Length-1;
            int even = 0, odd = 1;

            while (true)
            {
                while (even <= n && (arr[even] & 1) == 0)
                    even += 2;

                while (odd <= n && (arr[odd] & 1) != 0)
                    odd += 2;

                if (even <= n && odd <= n)
                    arr.Swap(even, odd);
                else break;
            }



        }

    }
}
