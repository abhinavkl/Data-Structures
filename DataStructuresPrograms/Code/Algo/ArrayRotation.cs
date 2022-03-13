using DataStructuresPrograms.Code.Basic;
using DataStructuresPrograms.Code.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Code.Algo
{
    internal static class ArrayRotation
    {
        //time complexity - O(n), space - O(1)
        public static int[] RotateLeft1ToNSorted(this int[] arr,int pos)
        {
            pos=pos%arr.Length;
            if (pos == 0)
                return arr;
            else
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    arr[i] = (arr[i] + pos)%arr.Length;
                    if(arr[i] == 0)
                        arr[i] = arr.Length;
                }
            }

            PrintObject.Print(arr);

            return arr;
        }

        public static int[] RotateLeftUnSorted(this int[] arr,int pos)
        {
            pos=pos%arr.Length;
            int partionIndexStart, curIndex,nextIndex,store;
            int partitionCount = MathOperations.GCD(pos,arr.Length);
            for(partionIndexStart = 0; partionIndexStart < partitionCount; partionIndexStart++)
            { 
                store= arr[partionIndexStart];
                for (curIndex = partionIndexStart,nextIndex=curIndex+pos; 
                    nextIndex!= partionIndexStart;
                    curIndex = nextIndex, nextIndex = (curIndex + pos)%arr.Length)
                {
                    arr[curIndex]=arr[nextIndex];
                }
                arr[curIndex] = store;
            }
            return arr;
        }
    }
}
