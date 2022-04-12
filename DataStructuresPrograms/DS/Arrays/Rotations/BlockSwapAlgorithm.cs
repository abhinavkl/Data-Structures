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
        /// [r1 r2 r3 e1 e2 e3 e4 e5] as rot < end-rot, we make last rot numbers in correct position.
        /// after this step (end-rot to end) will come to required position. so we operate Left rotate over start to end-rot.
        /// i.e, [r1 r2 r3 e1 e2] e3 e4 e5 
        /// 
        /// 
        /// loop:
        /// [r1 r2 r3 r4 r5 e1 e2 e3] as rot > end-rot, we make last end-rot numbers in correct position. 
        /// so we take start to rot and rot to end-rot, where rot is changed to end-rot, after this step first end-rot elements in correct position.
        /// So for next iteration we start from start+end-rot, to end. (r1 r2 r3 [r4 r5 e1 e2 e3]) now rot = rot-(end-rot), as (1,2,3,4,5)-(1,2,3)=2.
        /// 
        ///  
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
