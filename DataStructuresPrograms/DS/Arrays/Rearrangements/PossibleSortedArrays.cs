using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class PossibleSortedArrays
    {
        public PossibleSortedArrays(int[] arrA, int[] arrB)
        {
            GetPossibleArrays(arrA, arrB);
        }
        

        static void GetPossibleArrays(int[] arrA,int[] arrB)
        {
            List<List<int>> possibleArrays = new List<List<int>>();

            int[] arr = new int[arrA.Length + arrB.Length];
            int[] arrAIndexes = new int[arrA.Length];
            int[] arrBIndexes = new int[arrB.Length];

            int i = 0, j = 0, k = 0,l1=0,l2=0;
            while (i != arrA.Length && j != arrB.Length)
            {
                if (arrA[i] < arrB[j])
                {
                    arr[k++] = arrA[i];
                    arrAIndexes[l1++] = i++;
                }
                else
                {
                    arr[k] = arrB[j];
                    arrBIndexes[l2++] = j++;
                }
            }
            while (i != arrA.Length)
            {
                arr[k++] = arrA[i];
                arrAIndexes[l1++] = i++;
            }
            while (j != arrB.Length)
            {
                arr[k] = arrB[j];
                arrBIndexes[l2++] = j++;
            }

            for(int m = 0; m < arrAIndexes.Length; m++)
            {
                for(int n = arrAIndexes[m]; n < arr.Length; n++)
                {

                }
            } 
            

        }
    }
}
