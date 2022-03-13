using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Code.Objects
{
    internal class Tree
    {
        public Tree() { Nodes = new Dictionary<int, List<KeyValuePair<int, int>>>(); }
        public Dictionary<int, List<KeyValuePair<int, int>>> Nodes { get; set; }
    }

    internal static class _Tree
    {
        public static void AddRoute(this Tree tree, int index, int neighbourIndex, int weight)
        {
            tree.AddNode(index, neighbourIndex, weight);
            tree.AddNode(neighbourIndex, index, weight);
        }
        static void AddNode(this Tree tree, int index, int neighbourIndex, int weight)
        {
            if (!tree.Nodes.ContainsKey(index))
            {
                tree.Nodes[index] = new List<KeyValuePair<int, int>>();
            }
            tree.Nodes[index].Add(new KeyValuePair<int, int>(neighbourIndex, weight));
        }

        //DFS approach
        public static long MaxAllTranversals(this Tree tree, int current, int parent,long N,ref long ans)
        {
            long currentTreeSize = 1;
            var values = new List<KeyValuePair<int, int>>();
            if (tree.Nodes.TryGetValue(current, out values))
            {
                foreach (var pair in values)
                {
                    int ngbr=pair.Key;
                    int wt=pair.Value;

                    if (ngbr == parent)
                    {
                        continue;
                    }

                    long childTreeSize=tree.MaxAllTranversals(ngbr, current,N,ref ans);

                    long edgeContribution = 2 * Math.Min(childTreeSize,N-childTreeSize)*wt;

                    ans+=edgeContribution;
                    currentTreeSize += childTreeSize;
                }
            }
            return currentTreeSize;
        }

    }
}
