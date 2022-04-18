using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresPrograms.DS.Arrays.Rotations;

namespace DataStructuresPrograms.DS.Arrays
{
    internal class ArrayPrograms
    {
        public static void Run()
        {
            int[] arr = new int[] { 1,2,3,4,5,6,7 };
            //new RotateLeft(arr,2);
            //new ReversalAlgorithm(arr,2);
            //new BlockSwapAlgorithm(arr,2);
            arr = new int[] { 7,8,9,10,11,12,13,14,15,16,17,18,1,2,3,4,5,6};
            //new SearchInSortedRotatedArray(arr,1);
            new FindPairInSortedRotateArray(arr,36);
        }
    }
}
