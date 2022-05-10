using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.miscellaneous
{
    internal class MaximumCircularSubArraySum
    {
        public MaximumCircularSubArraySum(int[] arr)
        {
            Solver(arr);
        }

        /// <summary>
        /// 
        /// maxSoFar is returned when
        ///         the whole array is -ve, then maxSoFar is the maximum element
        ///         when no rotation required, then max is the maxSoFar itself.
        /// else we will return sum-minSoFar
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int Solver(int[] arr)
        {
            int n = arr.Length - 1;
            int curMaxSum = arr[0], curMinSum = arr[0];
            int maxSoFar = arr[0], minSoFar = arr[0];

            if (n == 1)
                return arr[0];

            int sum = arr.Sum();

            for(int i = 0; i < n; i++)
            {
                curMaxSum = Math.Max(curMaxSum+arr[i],curMaxSum);
                maxSoFar = Math.Max(curMaxSum,maxSoFar);


                curMinSum = Math.Min(curMinSum, curMinSum + arr[i]);
                minSoFar = Math.Min(curMinSum,minSoFar);
            }

            if (minSoFar == sum) //all negative numbers
            {
                return maxSoFar;
            }

            return Math.Max(maxSoFar, sum - minSoFar);
        }

    }
}
