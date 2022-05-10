using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class ZeroIndexChangeTo1ForLongestContinuousSequence
    {
        public ZeroIndexChangeTo1ForLongestContinuousSequence(int[] arr)
        {
            Solver(arr);
        }


        public int Solver(int[] arr)
        {

            int prevZero = -1;
            int prevPrevZero = -1;
            int maxDiff = int.MinValue;
            int pos = -1;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i]==0)
                {
                    if (maxDiff < i - prevPrevZero)
                    {
                        maxDiff = i - prevPrevZero;
                        pos = prevZero;
                    }
                    prevPrevZero = prevZero;
                    prevZero = i;
                }
            }

            if(maxDiff<arr.Length-prevPrevZero)
            {
                pos = prevZero;
            }    

            return pos;
        }

    }
}
