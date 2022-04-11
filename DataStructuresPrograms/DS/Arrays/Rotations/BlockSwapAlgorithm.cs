using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresPrograms.Extensions;

namespace DataStructuresPrograms.DS.Arrays.Rotations
{
    internal class BlockSwapAlgorithm
    {
        /// <summary>
        /// at first end is array length
        /// 
        /// loop:
        /// if rot is less than the end swap continuously last rot number of indices from end
        /// now rot wont be changed, start wont be changed but end will be reduced by rot number.
        /// 
        /// loop:
        /// if rot is greater than end swap continuously then swap from start index with rot index and till end
        /// (we either use end-rot or rot number of indices till it reaches half)
        /// 
        /// if both are same 
        /// then swap continuously from start with half till end.
        /// 
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="rot"></param>
        public BlockSwapAlgorithm(int[] arr,int rot)
        {
            LeftRotate(arr,0,rot,arr.Length);
        }
        public static int[] LeftRotate(int[] arr,int start,int rot,int end)
        {
            if (rot == 0 || rot == end)
                return arr;
            if (rot > end)
                rot = rot % end;
            if (end-rot == rot)
                return ContinuousSwap(arr,start,end-rot+start,rot);

            else if (rot < end - rot)
            {
                ContinuousSwap(arr,start,end-rot+start,rot);
                return LeftRotate(arr,start,rot,end-rot);
            }
            else
            {
                ContinuousSwap(arr,start,rot,end-rot); 
                return LeftRotate(arr,end-rot+start,2*rot-end,rot);
            }
        }

        public static int[] ContinuousSwap(int[] arr,int start,int end,int pos)
        {
            for(int i = 0; i < pos; i++)
            {
                arr.Swap(start+i,end+i);
            }
            return arr;
        }

    }
}
