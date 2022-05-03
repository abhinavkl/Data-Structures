using DataStructuresPrograms.Code.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.DynamicProgramming.Arrays
{
    internal class MaxProductSubArray
    {
        public MaxProductSubArray(int[] arr)
        {
            Solver(arr);
        }

        /// <summary>
        /// 
        /// least value which is negative gives highest positive number even multiplying with -1, so we use two maxProduct and minProduct, while they store max and min of all possible iterations.
        /// at each iteration we check maxProduct with prev maxProduct.
        /// 
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public void Solver(int[] arr)
        {
            int maxProduct = 1,minProduct=1;
            int prodLooper = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int temp = MathOperations.Max(arr[i], arr[i] * maxProduct, arr[i] * minProduct);
                minProduct = MathOperations.Min(arr[i], arr[i] * maxProduct, arr[i] * minProduct);
                maxProduct = temp;
                prodLooper = Math.Max(prodLooper,temp);
            }
        }

    }
}
