using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class MinSwapsforAllLessNumbersTogether
    {
        public MinSwapsforAllLessNumbersTogether(int[] arr,int k)
        {
            Solver(arr,k);
        }

        /// <summary>
        /// 
        /// 1. Count the no. of elements are less than or equal to required number. lets [count]
        /// 2. Loop through the array and take the better [count] elements' sub-array.
        /// 
        /// we store allLessCount = less elements count, and k = required Number
        /// at first calculate the min Swaps count for first [allLessCount] elements, i.e, [curSwaps]
        /// 
        /// and once we are looping through the array we increment and decrement its value, and check for the min. so first store it in minSwaps
        /// 
        /// once we start iterating through the array.
        /// i=0,j=allLessCount, as array indexes starts from 0, arr[j] points to next element of first [allLessCount] sub-array.
        /// 
        /// As everytime i increases our sub-array starting index increases.
        /// if arr[i] is less than or equal to k, then don't do anything. As we have to consider the min possible swaps for array and keep it in the count.
        /// if arr[i] is greater than k, then first decrease the minSwaps count and 
        ///                         if arr[j] is greater than k then increase. 
        ///                             Here if you see the minSwaps count didn't changes after these two steps but we are considering current sub-array for the minSwaps.
        ///                         else we are taking the current sub-array which requires less minSwaps than previous.
        /// So, in this way at each iteration we are decreasing the minSwaps count if first one is higher and giving chance to consider the minCount for the next possible sub array.
        /// 
        /// In this way we get minimum swap count.
        /// 
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        static int Solver(int[] arr,int k)
        {
            int allLessCount = arr.Where(i=> i<=k).Count();
            int curSwaps = arr.Take(allLessCount).Where(i => i > k).Count();

            int minSwaps = curSwaps;
            for(int i = 0, j = allLessCount; j < arr.Length; i++, j++)
            {
                if (arr[i] > k)
                    curSwaps--;
                if (arr[j] > k)
                    curSwaps++;

                minSwaps = Math.Min(minSwaps,curSwaps);
            }
            return minSwaps;
        }

    }
}
