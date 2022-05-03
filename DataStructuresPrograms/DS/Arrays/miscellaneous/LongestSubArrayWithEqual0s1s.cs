using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.miscellaneous
{
    internal class LongestSubArrayWithEqual0s1s
    {
        public LongestSubArrayWithEqual0s1s(int[] arr)
        {
            Solver(arr);
        }

        /// <summary>
        /// 
        /// to solve the program in O(n) time complexity we have to use a dictionary (hash).
        /// 
        /// lets take [1 0 1 1 0 1 0], as to make [1,0] a pair, we have to consider 0 as -1 in addition, both combinedly gives sum=0.
        ///    cumSum  1 0 1 2 1 2 1,
        ///    if you see in above, the first zero tells us that from starting index to 0th index formed sub-array is having equal number of 1 and 0.
        ///    
        ///     we use [cumSum] for cumaltive sum
        ///            [loopEndIndex] for loop end index
        ///            [maxLength] for sub array length
        /// 
        ///     once if we start iterating,
        ///     at i=0, cumSum=1 then we insert it to dictionary {it stores cumSum and its first occurred index} => (1,0)
        ///        i=1, cumSum=0 then we can assign the maxLength=2, loopEndIndex=1
        ///        i=2, cumSum=1, we have this value value in the loop. And as the number of elements in the loop is same as previous, we are not considering, {we consider only if it is greater}
        ///        i=3, cumSum=2, we add this to dictionary => (1,0),(2,2)
        ///        i=4, cumSum=1, now [i-prevOccurredIndex] => [4-sumCheck[cumSum]] => [4-0]=4,  therefore maxlength=4,loopEndIndex=4. {it will give start index, as startIndex= loopEndIndex-maxLength+1 } i.e, 1
        ///        i=5, cumSum=2, now see maxLength=4 from i=4, here we are gonna calculate [i-prevOccurredIndex] => [5-sumCheck[cumSum]] => [5-2]=3, as 4<3, which is false, we ignore it.
        ///        i=6, cumSum=1, now maxLength=4, here we are gonna calculate [i-prevOccurredIndex] => [6-sumCheck[cumSum]] => [6-0]=6, as 4<6, we will assign maxLength=6, loopEndIndex=6.
        ///         
        ///        by the end of the loop, maxLength=6, loopEndIndex=6, therefore startIndex=loopEndIndex-maxLength+1 => 6-6+1 = 1.
        ///        therefore the required subarray is btw 1 to 6.
        ///        
        /// 
        ///        Loop is formed when the sum=0 (startIndex=0 by default), or we encounter two same sums, we will only consider even them only when maxLength is less to that of previous occurred position to cur position.
        /// 
        /// 
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public void Solver(int[] arr)
        {
            int curSum = 0;
            int loopEndIndex = -1;
            int maxLength = 0;

            Dictionary<int, int> sumCheck = new Dictionary<int, int>();

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                    curSum += 1;
                else if (arr[i] == 0)
                    curSum -= 1;

                if (curSum == 0)
                {
                    maxLength = i + 1;
                    loopEndIndex = i;
                }
                
                if (sumCheck.ContainsKey(curSum))
                {
                    if(maxLength<i-sumCheck[curSum])
                    {
                        maxLength = i - sumCheck[curSum];
                        loopEndIndex = i;
                    }
                }
                else
                {
                    sumCheck[curSum] = i;
                }
            }
            int startIndex = loopEndIndex - maxLength + 1;
            Console.WriteLine($"{startIndex} to {loopEndIndex}");
        }

    }
}
