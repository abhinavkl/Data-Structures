using DataStructuresPrograms.Code.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class ArrayOfIisI //arr[i]=i
    {
        /// <summary>
        /// 
        /// start a ptr from 0 and till reaches array's length
        /// if arr[ptr] is -1 then ignore it 
        /// if arr[ptr] is ptr then ignore it
        /// if arr[ptr] is not -1 and not ptr then make it to its original position: apply following logic
        ///     as that element has to go to index, where index=arr[ptr]
        ///     we have to swap that ptr element with arr[ptr].
        ///     if arr[ptr] is -1 then ignore it, otherwise you have to make go its original position.
        /// 
        /// 
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public ArrayOfIisI(int[] arr)
        {
            Solve(arr);
        }
        static void Solve(int[] arr)
        {
            int n = arr.Length - 1;
            for(int ptr = 0; ptr <= n; ptr++)
            {
                if (arr[ptr] != -1 && arr[ptr]!=ptr)
                {
                    SwapRepeatedly(arr,ptr);
                }
            }
        }

        static void SwapRepeatedly(int[] arr,int ptr)
        {
            while ( ptr!=-1 && arr[ptr] != -1 && arr[ptr]!=ptr)
            {
                int holder = arr[ptr];
                int swapper = arr[arr[ptr]];
                arr[arr[ptr]] = arr[ptr];
                arr[ptr] = swapper;
                ptr = holder;
            }
        }



    }
}
