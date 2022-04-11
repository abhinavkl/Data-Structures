using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresPrograms.Code.Basic;
using DataStructuresPrograms.Code.Print;

namespace DataStructuresPrograms.DS.Arrays
{
    internal class Rotation
    {
        public static void Left(int[] arr,int rot)
        {
            PrintObject.Print(arr);

            int n = arr.Length;
            int actualRotation = rot % n;
            int loops=MathOperations.GCD(actualRotation,rot);
            int curIndex = 0;
            int nexIndex = 0;

            for(int loop = 0; loop < loops; loop++)
            {
                int temp = arr[loop];
                for(curIndex=loop,nexIndex=curIndex+actualRotation;
                    nexIndex<n;
                    curIndex=nexIndex,nexIndex=curIndex+actualRotation)
                {
                    arr[curIndex] = arr[nexIndex];
                }
                arr[curIndex] = temp;
            }

            PrintObject.Print(arr);
        }
    }
}
