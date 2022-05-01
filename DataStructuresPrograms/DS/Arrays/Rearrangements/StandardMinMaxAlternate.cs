using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class StandardMinMaxAlternate
    {
        /// <summary>
        /// 
        /// number= rem + quo*div;    { as per terminology [div] is always greater than [rem] } either of them is greater ( div or quo ) lets take [div] > [quo]
        /// and from a [number] we will get [rem] = [num]%[div]
        ///                             and [quo] = [num]/[div]
        ///                             
        /// we use same approach here, and once the array is sorted we can take [div] i.e, max element as array's max element+1
        /// 
        /// and to not loose previous data we store previous result as [rem] and next possible as [quo], and to store them at one index, we use 
        ///                     arr[index] = arr[index] + ( arr[next] ) * max 
        ///                     number     =   rem      +   [quo]      * [div]
        ///                     
        /// but we indexes are already get updated, so to get their previous result, we use % for that number.
        ///                     arr[index] = arr[index] + ( arr[next] % max ) * max
        /// 
        /// we use two pointers for min and max element indexes and decrease and increase them once we use them.
        /// 
        /// and at the end, to get new numbers we have divide them with [div] i.e, max
        /// 
        /// 
        /// Time  Complexity :- O(nlogn)
        /// Space Complexity :- O(1)
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public StandardMinMaxAlternate(int[] arr)
        {
            Array.Sort(arr);
            MinMaxAlternateSolver(arr);
        }

        static void MinMaxAlternateSolver(int[] arr)
        {
            int n = arr.Length - 1;
            int minIndex = 0, maxIndex = n;
            int maxElement = arr[n] + 1;

            for(int i = 0; i <= n; i++)
            {
                if( (i&1)==0)
                {
                    arr[i] = arr[i] + (arr[minIndex++] % maxElement) * maxElement;
                }
                else
                {
                    arr[i] = arr[i] + (arr[maxIndex--] % maxElement ) * maxElement ;
                }
            }

            for(int i = 0; i <= n; i++)
            {
                arr[i] = arr[i] / maxElement;
            }
        }

    }
}
