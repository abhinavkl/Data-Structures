using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Code.Objects
{
    
    internal class SegmentTree
    {
        public List<int> values { get; set; } = new List<int>();
    }
    internal static class _SegmentTree
    {
        static void Build(this SegmentTree segmentTree,int node,int left,int right,int[] arr)
        {
            if (left==right)
                segmentTree.values[left] = arr[right];
            segmentTree.Build(left,left,right/2,arr);
            segmentTree.Build(right, (right / 2) + 1, right, arr);
            segmentTree.values[node] = segmentTree.values[2 * node + 1]+segmentTree.values[2*node+2];
        }
        public static void Build(this SegmentTree segmentTree,int[] arr)
        {

        }
    }
}
