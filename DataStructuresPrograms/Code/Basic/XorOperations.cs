using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Code.Algo
{
    internal class XorOperations
    {
        public int[] Decode(int[] arr)
        {
            int [] result = new int[arr.Length+1];
            int temp = 0;
            result[0] = temp;
            for (int i = 1; i < arr.Length; i++)
            {
                result[i] = arr[i]^arr[i-1];
            }
            result[0] = result[1] ^ arr[0] ;
            result[arr.Length] = arr[arr.Length-1]^result[arr.Length-1];
            return result;
        }
    }
}
