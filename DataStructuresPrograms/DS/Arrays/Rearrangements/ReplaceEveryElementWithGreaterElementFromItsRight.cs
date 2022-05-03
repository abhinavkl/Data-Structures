using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class ReplaceEveryElementWithGreaterElementFromItsRight
    {
        public ReplaceEveryElementWithGreaterElementFromItsRight(int[] arr)
        {
            Solver(arr);
        }

        /// <summary>
        /// 
        /// at first store max as the last element.
        /// 
        /// while iterating through the array elements, everytime store the curElement to check whether it is the next greater element, and place the last max element in it, and calculate next max element.
        /// 
        /// </summary>
        /// <param name="arr"></param>

        public void Solver(int[] arr)
        {
            int n = arr.Length - 1;
            int max = arr[n];
            arr[n] = -1;
            for (int i = n-1; i >= 0; i--)
            {
                int temp = arr[i];
                arr[i] = max;
                max = Math.Max(max, temp);                
            }



        }
    }
}
