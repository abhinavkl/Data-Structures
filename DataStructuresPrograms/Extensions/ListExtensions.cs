using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Extensions
{
    internal static class ListExtensions
    {
        public static void Swap(this List<int> list,int i,int j)
        {
            if(i<list.Count && j<list.Count && i!=j && list[i] != list[j])
            {
                list[i] = list[i] ^ list[j];
                list[j] = list[i] ^ list[j];
                list[i] = list[i] ^ list[j];
            }
        }

        static void MaxHeapify(List<int> list,int node,int index)
        {
            int min = index;

            int left = 2 * index + 1;
            int right = 2 * index + 2;

            if (left < node && list[left] < list[min])
                min = left;
            if (right < node && list[right] < list[min])
                min = right;
            if (min != index)
            {
                list.Swap(min, index);
                MaxHeapify(list, node, min);
            }
        }

        static void MinHeapify(List<int> list,int node,int index)
        {
            int max = index;

            int left = 2 * index+1;
            int right = 2 * index + 2;
            
            if (left<node && list[left] > list[max])
                max = left;
            if (right < node && list[right] > list[max])
                max = right;
            if (max != index)
            {
                list.Swap(max,index);
                MinHeapify(list,node,max);
            }
        }
        public static List<int> HeapSortAsc(this List<int> list)
        {
            int n = list.Count;
            for (int i =  (n/ 2)-1; i >= 0; i--)
            {
                MinHeapify(list,n,i);
            }

            for(int i = n - 1; i >= 0; i--)
            {
                list.Swap(i,0);
                MinHeapify(list,i,0);
            }
            return list;
        }

        public static List<int> HeapSortDesc(this List<int> list)
        {
            int n = list.Count;
            for (int i = (n / 2) - 1; i >= 0; i--)
            {
                MaxHeapify(list, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                list.Swap(i, 0);
                MaxHeapify(list, i, 0);
            }
            return list;
        }

        public static List<int> GetTopKElements(this List<int> list,int k)
        {
            List<int> kElements = new List<int>();
            for(int i = 0; i < k; i++)
            {
                kElements.Add(list[i]);
            }

            kElements.HeapSortDesc();

            for(int i = k; i < list.Count; i++)
            {
                if (kElements[k - 1] < list[i])
                {
                    kElements[k - 1] = list[i];
                    kElements.HeapSortDesc();
                }
            }
            return kElements;
        }

        public static List<int> GetLeastKElements(this List<int> list, int k)
        {
            List<int> kElements = new List<int>();
            for (int i = 0; i < k; i++)
            {
                kElements.Add(list[i]);
            }

            kElements.HeapSortAsc();

            for (int i = k; i < list.Count; i++)
            {
                if (kElements[k - 1] > list[i])
                {
                    kElements[k - 1] = list[i];
                    kElements.HeapSortAsc();
                }
            }
            return kElements;
        }

        public static int? GetKthLargestElement(this List<int> list,int k)
        {
            if (k > list.Count) return null;
            return list.GetTopKElements(k)[k - 1];
        }

        public static int? GetKthSmallestElement(this List<int> list,int k)
        {
            if (k > list.Count) return null;
            return list.GetLeastKElements(k)[k - 1];
        }
    }
}
