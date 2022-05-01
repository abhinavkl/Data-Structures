using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class StandardMinMaxAlternateWithExtraSpace
    {
        /// <summary>
        /// 
        /// at first sort the array
        /// use temp array to store the result, and use two pointers one points to maxIndex and another minIndex of array.
        /// And use these two pointers for the insertion into the temp array.
        /// change the elements of the original array.
        /// 
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public StandardMinMaxAlternateWithExtraSpace(int[] arr)
        {
            Array.Sort(arr);
            Solver(arr);
        }

        static void Solver(int[] arr)
        {
            int[] temp = new int[arr.Length];
            int tempIndex = 0;

            for(int i = 0,j=arr.Length-1; i <= j; i++,j--)
            {
                if (i == j)
                    temp[tempIndex] = arr[i];
                else
                {
                    temp[tempIndex++] = arr[i];
                    temp[tempIndex++] = arr[j];
                }
            }
            
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = temp[i];
            }


        }

    }
}
