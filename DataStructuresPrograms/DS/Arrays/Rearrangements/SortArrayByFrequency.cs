using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class SortArrayByFrequency
    {
        public SortArrayByFrequency(int[] arr)
        {
            Solver(arr);
        }

        /// <summary>
        /// 
        /// insert into binary search tree with counting the frequencies -> O(nlogn)
        /// store these value and frequency pair in a list and sort by a comparator 
        /// and then replace the array elements by adding value until its frequency is 0.
        /// 
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public void Solver(int[] arr)
        {
            Node node = new Node();
            foreach(var i in arr)
            {
                node.Add(i);
            }
            node.InorderPrint();
            List<Data> elementsWithFrequencies = node.GetDictionary();
            elementsWithFrequencies.Sort(DataComparator);

            for(int i = 0,j=0;j<elementsWithFrequencies.Count;j++)
            {
                while(elementsWithFrequencies[j].Frequency-- != 0 && i<arr.Length)
                {
                    arr[i++] = elementsWithFrequencies[j].Value;
                }
            }
        }

        public int DataComparator(Data data1,Data data2)
        {
            return data1.Frequency > data2.Frequency ? -1 : 1;
        }

    }

    class Data
    {
        public int Value { get; set; }
        public int Frequency { get; set; }
    }

    class Node
    {
        public int? Value { get; set; }
        public int Frequency { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }

        public Node() { }
        public static Node NewNode(int num)
        {
           return new Node(){
               Value=num, Frequency=1
            };
        }
        public void Add(int num)
        {
            if (this.Value == null)
            {
                this.Value = num;
                this.Frequency = 1;
                this.Right = null;
                this.Left = null;
            }
            else
            {
                if (num == Value)
                {
                    this.Frequency++;
                }
                else if (num > Value)
                {
                    if (this.Right == null)
                        this.Right = Node.NewNode(num);
                    else
                        this.Right.Add(num);
                }
                else
                {
                    if (this.Left == null)
                        this.Left = Node.NewNode(num);
                    else
                        this.Left.Add(num);
                }
            }
        }
    }

    static class _Node
    {
        public static void InorderPrint(this Node node)
        {
            if (node.Right != null)
                node.Right.InorderPrint();
            Console.WriteLine(node.Value+" "+node.Frequency);
            if (node.Left != null)
                node.Left.InorderPrint();
        }

        static List<Data> GetDictionary(this Node node,List<Data> valueFrequencies)
        {
            if (node.Right != null)
                node.Right.GetDictionary(valueFrequencies);
            valueFrequencies.Add(new Data() { Value= node.Value.Value, Frequency= node.Frequency });
            if (node.Left != null)
                node.Left.GetDictionary(valueFrequencies);
            return valueFrequencies;

        }
        public static List<Data> GetDictionary(this Node node)
        {
            List<Data> valueFrequencies = new List<Data>();

            return node.GetDictionary(valueFrequencies);
        }
    }

}
