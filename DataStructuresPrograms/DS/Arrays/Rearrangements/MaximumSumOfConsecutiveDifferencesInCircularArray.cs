using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class MaximumSumOfConsecutiveDifferencesInCircularArray
    {
        //|a1 – a2| + |a2 – a3| + …… + |an – 1 – an| + |an – a1|
        public MaximumSumOfConsecutiveDifferencesInCircularArray(int[] arr)
        {
            Solver(arr);
        }

        /// <summary>
        /// 
        /// At first we have to sort the array, and as we are using modulous we will add maximum values and substract minimum values.
        /// so, i will add 2 times of right value and substract 2 times of left value and increase and decrease the indices.
        /// 
        /// </summary>
        /// <param name="arr"></param>
        static void Solver(int[] arr)
        {
            Array.Sort(arr);

            int sum = 0;

            for(int i = 0, j = arr.Length - 1; i < j; i++, j--)
            {
                sum += 2 * (arr[j]) - 2 * arr[i];
            }
        }

    }
}
