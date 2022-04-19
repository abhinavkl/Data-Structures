using DataStructuresPrograms.Code.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rotations
{
    internal class MaxSummationOfIndexNumberOnRotation
    {
        /// <summary>
        /// a0 a1 a2 a3
        ///  0  1  2  3 => 
        /// arrSum = a0 + a1 + a2 + a3
        /// cur_ind_sum = a1 + 2a2 + 3a3
        ///  
        /// next required value is ( a0 + 2a1 + 3a2 ) which can be solved using above soln
        /// ( a0 + 2a1 + 3a2 ) = ( a0 + 2a1 + 3a2 )
        ///                    = ( a0 + 2a1 + 3a2 + 4a3) - 4a3
        ///                    = ( a0 + a1 + a2 + a3) + ( a1 + 2a2 + 3a3 ) - 4a3  {here 4a3 is iteration value it changes to 4a2...}
        /// 
        /// at first we calculate ( a1 + 2a2 + 3a3 ) normally and then using iterator from 1 to n-1 we caculate all other values 
        /// and in the above 4a3 is actually n*a[n-1]
        /// 
        /// and at each iteration we check for a max value.
        /// 
        /// 
        /// at the end we return max.
        ///  
        /// </summary>
        /// <param name="arr"></param>
        public MaxSummationOfIndexNumberOnRotation(int[] arr)
        {
            int n=arr.Length;
            int arr_sum=arr.ToList().Sum();
            int cur_ind_sum=arr.ToList().Select( (i,cv)=> i*cv ).ToList().Sum();
            int maxSum = Int32.MinValue;

            for(int i = 1; i < n; i++)
            {
                cur_ind_sum += arr_sum - n * arr[n - i];
                maxSum = Math.Max(maxSum, cur_ind_sum);
            }

            PrintObject.Print(maxSum);
        }
    }
}
