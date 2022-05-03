﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresPrograms.DS.Arrays.miscellaneous;
using DataStructuresPrograms.DS.Arrays.Rearrangements;
using DataStructuresPrograms.DS.Arrays.Rotations;

namespace DataStructuresPrograms.DS.Arrays
{
    internal class ArrayPrograms
    {
        public static void Run()
        {

            int[] arr = new int[] { 1,2,3,4,5,6,7 };

            #region Rotations
            //new RotateLeft(arr,2);
            //new ReversalAlgorithm(arr,2);
            //new BlockSwapAlgorithm(arr,2);
            arr = new int[] { 11,12,13,14,15,16,17,18,1,2,3,4,5,6,7,8};
            //new SearchInSortedRotatedArray(arr,1);
            //new FindPairInSortedRotateArray(arr,36);
            //arr = new int[] { 8,3,1,2 };
            //new MaxSummationOfIndexNumberOnRotation(arr);
            //new RotationCount(arr);
            #endregion

            #region Rearrangements
            arr = new int[] { -1, -1, 6, 1, 9, 3, 2, -1, 4, -1 };
            //new ArrayOfIisI(arr);
            arr = new int[] { 4, 5, 1, 2 };
            //new ReverseArray(arr);
            arr = new int[] { 42,11,23,72,01,34,98,57,82,61,121 };
            //new StandardMaxMinAlternate(arr);
            arr = new int[] { -1,-2,3,4,-5,6,-7,-8,9,10,11,-12 };
            //new PositivesAndNegativesAside(arr);
            arr = new int[] { 10, 1, 2, 3, 11, 4, 5, 7, 6 };
            //new MinSwapsforAllLessNumbersTogether(arr,5);
            //new NormalMaxMinAlternate(arr);
            arr = new int[] { 42, 11, 23, 72, 01, 34, 98, 57, 82, 61, 121 };
            //new StandardMinMaxAlternate(arr);
            //new StandardMinMaxAlternateWithExtraSpace(arr);
            arr = new int[] { 50, 40, 70, 60, 90 };
            int[] ind = new int[] { 3, 0, 4, 1, 2 };
            //new ReorderAnArrayWithGivenIndices(arr,ind);
            arr = new int[] { 1, 34, 3, 98, 9, 76, 45, 4 };
            //new GetMaximumNumberWithAllElements(arr);
            arr = new int[]{ 1, -3, 5, 6, -3, 6, 7, -4, 9, 10};
            //new PositiveNegativesSideBySideWithoutOrder(arr);
            arr = new int[] {5,4,3,2,1};
            //new EvenAndOddAsideQuickSortApproach(arr);
            //new EvenAndOddSideBySideAingleMergeLoopApproach(arr);
            //new EvenAndOddAsideMergeSortApproach(arr);
            //new Size3SortedSubsequence(arr);
            arr = new int[] { 0,0,0,1, 0, 1, 1, 1, 0, 0,1,0,1,1,1,0,0 };
            //new LongestSubArrayWithEqual0s1s(arr);
            arr = new int[] { 10, 1, 2, 3, 11, 4, 5, 7, 6 };
            //new ReplaceEveryElementWithGreaterElementFromItsRight(arr);
            #endregion



            #region
            #endregion


        }
    }
}
