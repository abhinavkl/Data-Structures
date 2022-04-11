using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresPrograms.Extensions;

namespace DataStructuresPrograms.DS.Arrays.Rotations
{
    internal class ReversalAlgorithm
    {
        /// <summary>
        /// first rotate arr by indices 0 to rot-1
        /// rotate the arr by indices rot to arr.length
        /// rotate the whole array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="rot"></param>
        public ReversalAlgorithm(int[] arr,int rot)
        {
            arr.Rotate(0,rot-1);
            arr.Rotate(rot,arr.Length-1);
            arr.Rotate();
        }

        

    }
}
