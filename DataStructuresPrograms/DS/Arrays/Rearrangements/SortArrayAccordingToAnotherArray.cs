using DataStructuresPrograms.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays.Rearrangements
{
    internal class SortArrayAccordingToAnotherArray
    {
        public SortArrayAccordingToAnotherArray(int[] arr,int[] refArr)
        {
            Solver(arr,refArr);
        }

        static void Solver(int[] arr,int[] refArr)
        {
            qSort(arr);
            int iterator = 0;
            for(int i = 0; i < refArr.Length; i++)
            {
                int start = FindStartIndex(arr, refArr[i],iterator,arr.Length-1);
                int end = FindEndIndex(arr, refArr[i],iterator,arr.Length-1);
                if (start != -1)
                {
                    AddElements(arr,iterator,start, end - start + 1);
                    iterator += end - start + 1;
                    arr.Reverse(iterator,start-1);
                    arr.Reverse(start,end);
                    arr.Reverse(iterator,end);
                }
            }
        }

        static void AddElements(int[] arr,int iterator,int start,int numOfPos)
        {
            for (int i = 0; i < numOfPos; i++)
            {
                arr.Swap(iterator++,start++);
            }
        }


        static int FindStartIndex(int[] arr,int key,int start,int end)
        {
            int pos = -1;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (arr[mid] == key)
                {
                    pos = mid;
                    end = mid - 1;
                }
                else if (arr[mid] > key)
                {
                    end = mid - 1;
                }
                else start = mid + 1;
            }

            return pos;
        }

        static int FindEndIndex(int[] arr, int key, int start, int end)
        {
            int pos = -1;
            
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (arr[mid] == key)
                {
                    pos = mid;
                    start = mid + 1;
                }
                else if (arr[mid] > key)
                {
                    end = mid - 1;
                }
                else start = mid + 1;
            }

            return pos;
        }

        static void qSort(int[] arr)
        {
            qSort(arr,0,arr.Length-1);
        }

        static void qSort(int[] arr,int start,int end)
        {
            if (start < end)
            {
                int pivot = GetPivot(arr,start,end);
                qSort(arr,start,pivot-1);
                qSort(arr, pivot + 1, end);
            }
        }

        static int GetPivot(int[] arr,int start,int end)
        {
            int pivot = arr[end];
            int iterator = start - 1;

            for(int i = start; i < end; i++)
            {
                if (arr[i] < pivot)
                    arr.Swap(i,++iterator);
            }
            arr.Swap(++iterator, end);

            return iterator;
        }

    }
}
