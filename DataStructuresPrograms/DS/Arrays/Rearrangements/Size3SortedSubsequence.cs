using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class Size3SortedSubsequence
    {
        public Size3SortedSubsequence(int[] arr)
        {
            Solver(arr);
        }

        /// <summary>
        /// 
        /// to find the size 3 sorted subsequence, first we need to give [first] = arr[0], we can change it accordingly later
        /// [second] only assigned once if we know element is greater than [first]
        /// 
        /// if [secondElementIndex] is -1, then it means the [first] is assigned, and we will change [first] to the best min possible value in each iteration.
        /// if we find a value in btw [first] and [second] { currently it is int.MaxValue}, then we will assign it to [second].
        /// 
        /// if [first] and [second] are assigned then we iterate the array only to find [third], which will be greater than [second], so in the meanwhile if we didn't find the greater element at each iteration for [third] we will replace the [second] value as it is the min for the [second] and we will replace it only if [first]<arr[i]<[second].
        /// 
        /// in this way we will find the size 3 sorted subsequence
        /// 
        /// 
        /// </summary>
        /// <param name="arr"></param>

        static void Solver(int[] arr)
        {
            int first = arr[0];
            int second = int.MaxValue;
            int secondElementIndex = -1;

            for(int i=1;i<arr.Length;i++)
            {
                if(secondElementIndex==-1)
                {
                    if (arr[i] > first && arr[i] < second)
                    {
                        second = arr[i];
                        secondElementIndex = i;
                    }
                    else if (arr[i] < first)
                    {
                        first = arr[i];
                    }
                }
                else
                {
                    if (arr[secondElementIndex] < arr[i])
                    {
                        Console.WriteLine($"{first}, {second}, {arr[i]}");
                        break;
                    }
                    else if (arr[i] > first && arr[i] < second)
                    {
                        second = arr[i];
                        secondElementIndex = i;
                    }
                }
            }

        }

    }
}
