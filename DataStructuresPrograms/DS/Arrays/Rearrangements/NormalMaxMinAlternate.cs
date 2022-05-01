using DataStructuresPrograms.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class NormalMaxMinAlternate
    {
        public NormalMaxMinAlternate(int[] arr)
        {
            Solver(arr);
        }

        /// <summary>
        /// 
        /// we can solve it in one loop only.
        /// 
        /// if cur iteration is even and cur is less than its previous
        /// if cur iteration is odd and cur is greater than its previous
        /// 
        /// 
        /// </summary>
        /// <param name="arr"></param>
        static void Solver(int[] arr)
        {
            int n = arr.Length - 1;

            for(int i = 1; i <= n; i++)
            {
                if (((i & 1) == 0 && arr[i] < arr[i - 1]) // if even and cur is less than its previous
                 || (i & 1) != 0 && arr[i] > arr[i - 1])  // if odd and cur is greater than its previous
                {
                    arr.Swap(i, i - 1);
                }
            }

        }
    }
}
