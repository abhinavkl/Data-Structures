using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.DynamicProgramming.Arrays
{
    internal class LongestBitonicSubsequence
    {
        public LongestBitonicSubsequence(int[] arr)
        {
            Solver(arr);
        }

        /// <summary>
        /// 
        /// for every index of array there will be possible increasing subsequnce and decreasing subsequence
        /// so, we have to find two arrays where one will have increasing subsequence till each index, one will have decreasing subsequence till each index.
        /// 
        /// once they got computed we have to take the maximum of each indices' increasing and decreasing subsequence count-1. {that index element present in both.}
        /// 
        /// finding increasing and decreasing subsequence :-
        /// 
        /// increasing :-
        ///         
        ///         We have to use an array for storing the increasing subsequence values.
        ///         as the first value itself create an 1 length of subsequence, we have to give 1 for the first value.
        ///         
        ///         as the comparison start from 1st index element with 0th element index, the i starts from 1, and j start from 0.
        ///         as to give every elements its possible largest subsequence value, we give max value of incSubSeq[i] for each incSubSeq[j], here incSubSeq[i] will change more than once, and as we are giving max at each check, at the completion of loop it will have max possible value.
        /// 
        ///         in this way we will find for each index.
        /// 
        /// to find largest decreasing subsequence, we have to traverse array reverse, because each index value depends on its previous value.
        /// 
        /// decreasing :-
        /// 
        ///         We have to use an array for storing the decreasing subsequence values.
        ///         as the first value itself create an 1 length of subsequence, we have to give 1 for the first value. i.e, [arr.Length-1] {suppose n=arr.Length} index=1
        ///         
        ///         as the comparison start from 1st last index element with 0th last element index, the i starts from 1 i.e, n-2, and j start from 0 i.e, n-1.
        ///         as to give every elements its possible largest subsequence value, we give max value of decSubSeq[i] for each decSubSeq[j], here decSubSeq[i] will change more than once, and as we are giving max at each check, at the completion of loop it will have max possible value.
        /// 
        ///         in this way we will find for each index.
        /// 
        /// 
        /// </summary>
        /// <param name="arr"></param>
        static void Solver(int[] arr)
        {
            int[] increasingSequence = GetIncreasingSubsequence(arr);
            int[] decreasingSequence = GetDecreasingSubsequence(arr);

            int max = int.MinValue;
            for(int i = 0; i < arr.Length; i++)
            {
                max = Math.Max(max,increasingSequence[i]+decreasingSequence[i]-1);
            }
        }

        static int[] GetIncreasingSubsequence(int[] arr)
        {
            int[] incSubSeq = new int[arr.Length];

            incSubSeq[0] = 1;
            for(int i = 1; i < arr.Length; i++)
            {
                incSubSeq[i] = 1;
                for(int j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j] && incSubSeq[i] < incSubSeq[j] + 1)
                        incSubSeq[i] = incSubSeq[j] + 1;
                }
            }
            return incSubSeq;
        }

        static int[] GetDecreasingSubsequence(int[] arr)
        {
            int[] decSubSeq = new int[arr.Length];

            decSubSeq[arr.Length - 1] = 1;
            for(int i = arr.Length - 2; i >= 0; i--)
            {
                decSubSeq[i] = 1;
                for(int j = arr.Length- 1; j > i; j--)
                {
                    if (arr[i] > arr[j] && decSubSeq[i] < decSubSeq[j]+1)
                        decSubSeq[i] = decSubSeq[j]+1;
                }
            }

            return decSubSeq;
        }

    }

}
