using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresPrograms.Code.Basic;
using DataStructuresPrograms.Code.Print;

namespace DataStructuresPrograms.DS.Arrays.Rotations
{
    internal class RotateLeft
    {
        /// <summary>
        /// n is array length, rot is rotation by which it has to rotate
        /// actualRotation is taken as if rotation may be greater than array length, so percentile taken
        /// partitions is taken by gcd of actualrotation and array length
        /// 
        /// i.e,   arr,n are passed
        /// n=arr.Length
        /// actualRotation=rot%n
        /// loop = gcd(actualRotation,n)
        /// 
        /// curIndex and nextIndex are taken to iterate over the array, nextIndex will give the element index that will come after rotation.
        /// for each partitions loop through the array by moving over rot, change the array values, store the starting value and assign it to last one.
        /// array elements are rotated
        /// 
        /// i.e,
        /// curIndex=0,nextIndex=0 (just initialization)
        /// for(i=0;i<partitions;i++)
        ///     store=arr[i]
        ///                     for(curIndex=loop,nexIndex=curIndex+actualRotation;
        ///                         nexIndex<n;
        ///                         curIndex=nexIndex,nexIndex=curIndex+actualRotation
        ///                        )
        ///                          arr[curIndex]=arr[nextIndex]
        /// 
        ///     arr[curIndex]=store
        /// 
        /// 
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="rot"></param>
        public RotateLeft(int[] arr, int rot)
        {
            PrintObject.Print(arr);

            int n = arr.Length;
            int actualRotation = rot % n;
            int loops = MathOperations.GCD(actualRotation, n);
            int curIndex = 0;
            int nexIndex = 0;

            for (int loop = 0; loop < loops; loop++)
            {
                int temp = arr[loop];
                for (curIndex = loop, nexIndex = curIndex + actualRotation;
                    nexIndex < n;
                    curIndex = nexIndex, nexIndex = curIndex + actualRotation)
                {
                    arr[curIndex] = arr[nexIndex];
                }
                arr[curIndex] = temp;
            }

            PrintObject.Print(arr);
        }

    }
}
