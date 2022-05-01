using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class GetMaximumNumber
    {
        public GetMaximumNumber(int[] arr)
        {
            Solver(arr);
        }

        /// <summary>
        /// 
        /// implement sort comaparator, and join the result
        /// 
        /// </summary>
        /// <param name="arr"></param>
        static void Solver(int[] arr)
        {
            //string[] nums = arr.ToList().ConvertAll<string>(delegate(int i) { return i.ToString(); }).ToArray();
            //nums= arr.Select(i => i.ToString()).ToArray(); 
            //nums = arr.Select(delegate (int i) { return i.ToString(); }).ToArray();
            //Array.Sort(nums,comparator);
            //StringBuilder stringBuilder = new StringBuilder();
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    stringBuilder.Append(nums[i]);
            //}

            Array.Sort(arr,comparator);
            var sb = String.Join("",arr);


        }

        static int comparator(string x,string y)
        {
            return (y+x).CompareTo(x+y)>0? 1 : -1;
        }

        static int comparator(int x,int y)
        {
            return (y.ToString() + x.ToString()).CompareTo(x.ToString() + y.ToString()) > 0 ? 1 : -1;
        }

    }
}
