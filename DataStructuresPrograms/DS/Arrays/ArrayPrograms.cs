using DataStructuresPrograms.DS.Arrays.Rearrangements;
using DataStructuresPrograms.DS.Arrays.Order;

namespace DataStructuresPrograms.DS.Arrays
{
    internal class ArrayPrograms
    {
        public static void Run()
        {

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            #region Rotations
            //new RotateLeft(arr,2);
            //new ReversalAlgorithm(arr,2);
            //new BlockSwapAlgorithm(arr,2);
            arr = new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 1, 2, 3, 4, 5, 6, 7, 8 };
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
            arr = new int[] { 42, 11, 23, 72, 01, 34, 98, 57, 82, 61, 121 };
            //new StandardMaxMinAlternate(arr);
            arr = new int[] { -1, -2, 3, 4, -5, 6, -7, -8, 9, 10, 11, -12 };
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
            arr = new int[] { 1, -3, 5, 6, -3, 6, 7, -4, 9, 10 };
            //new PositiveNegativesSideBySideWithoutOrder(arr);
            arr = new int[] { 5, 4, 3, 2, 1 };
            //new EvenAndOddAsideQuickSortApproach(arr);
            //new EvenAndOddSideBySideAingleMergeLoopApproach(arr);
            //new EvenAndOddAsideMergeSortApproach(arr);
            //new Size3SortedSubsequence(arr);
            arr = new int[] { 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0 };
            //new LongestSubArrayWithEqual0s1s(arr);
            arr = new int[] { 2, 3, 2, 4, 5, 12, 2, 3, 3, 3, 12 };
            //new ReplaceEveryElementWithGreaterElementFromItsRight(arr);
            //new SortArrayByFrequency(arr);
            arr = new int[] { 10, 12, 15 };
            //new MaximumSumOfConsecutiveDifferencesInCircularArray(arr);
            arr = new int[] { 2, 1, 2, 5, 7, 1, 9, 3, 6, 8, 8 };
            int[] refArr = new int[] { 2, 1, 8, 3 };
            //new SortArrayAccordingToAnotherArray(arr, refArr);
            arr = new int[] { 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1 };
            //new ZeroIndexChangeTo1ForLongestContinuousSequence(arr);
            arr =new int[]{ 1, 14, 5, 20, 4, 2, 54, 20, 87, 98, 3, 1, 32 };
            //new ThreeWayPartitioning(arr, 14, 20);
            arr = new int[] { 10, 15, 25 };
            refArr = new int[] { 1, 5, 20, 30 };
            //new PossibleSortedArrays(arr,refArr);
            #endregion

            #region Order Statistics
            arr = new int[] { 7, 10, 4, 3, 20, 15 ,9,8,6,13,12};
            //new KthSmallestElement(arr,3);
            //new KthLargestElement(arr,3);
            new KthSmallestQuickSelect(arr, 3);
            //new KthLargestQuickSelect(arr, 3);
            #endregion


            #region
            #endregion


        }
    }
}
