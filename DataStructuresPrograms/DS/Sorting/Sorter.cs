using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Sorting
{
    internal class Sorter
    {
        public static void Run()
        {

            int[] arr = new int[] { 42, 11, 23, 72, 01, 34, 98, 57, 82, 61, 121 };
            new QuickSort(arr);
        }
    }
}
