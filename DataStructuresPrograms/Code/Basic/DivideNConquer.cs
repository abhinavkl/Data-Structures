using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresPrograms.Extensions;

namespace DataStructuresPrograms.Code.Basic
{
    internal static class DivideNConquer
    {

        static int[] MergeSortedParts(int[] arr, int start, int mid, int end)
        {
            int[] store = new int[end - start + 1];
            int storeIndex = 0;
            int leftArrayIndex = start;
            int rightArrayIndex = mid + 1;
            while (leftArrayIndex <= mid && rightArrayIndex <= end)
            {
                if (arr[leftArrayIndex] <= arr[rightArrayIndex])
                {
                    store[storeIndex++] = arr[leftArrayIndex++];
                }
                else
                    store[storeIndex++] = arr[rightArrayIndex++];
            }
            while (rightArrayIndex <= end)
            {
                store[storeIndex++] = arr[rightArrayIndex++];
            }
            while (leftArrayIndex <= mid)
            {
                store[storeIndex++] = arr[leftArrayIndex++];
            }

            storeIndex = 0;
            for (int i = start; i <= end; i++)
            {
                arr[i] = store[storeIndex++];
            }
            return arr;
        }
        public static int[] MergeSort(this int[] arr, int start = 0, int end = -1)
        {
            if (end == -1)
                end = arr.Length - 1;
            if (start >= end)
                return arr;
            int mid = (start + end) / 2;
            MergeSort(arr, start, mid);
            MergeSort(arr, mid + 1, end);
            arr = MergeSortedParts(arr, start, mid, end);
            return arr;
        }

        public static int ApplyQuickSort(int[] arr, int start, int end)
        {
            int pivot = arr[end];

            int iterator = start - 1;

            for (int i = start; i < end; i++)
            {
                if (arr[i] < pivot)
                {
                    arr = arr.Swap(++iterator, i);
                }
            }
            arr.Swap(++iterator, end);

            return iterator;
        }
        public static int[] QuickSort(this int[] arr, int start = 0, int end = -1)
        {
            if (end == -1)
                end = arr.Length - 1;

            if (start >= end)
                return arr;

            int pivot = ApplyQuickSort(arr, start, end);
            QuickSort(arr, start, pivot - 1);
            QuickSort(arr, pivot + 1, end);

            return arr;
        }

        public static int QuickSelectPosition(int[] arr, int pos)
        {
            QuickSelect(arr, pos, 0, arr.Length - 1);
            return arr[pos];
        }
        static int[] QuickSelect(int[] arr, int pos, int start, int end)
        {
            if (start >= end)
                return arr;
            int pivot = ApplyQuickSort(arr, start, end);
            if (pivot > pos)
            {
                QuickSelect(arr, pos, start, pivot - 1);
            }
            else if (pivot < pos)
            {
                QuickSelect(arr, pos, pivot + 1, end);
            }
            return arr;
        }

        static int InversioncountWhileMerge(int[] arr, int start, int mid, int end)
        {
            int[] store = new int[end - start + 1];
            int storeIndex = 0;
            int leftArrayIndex = start;
            int rightArrayIndex = mid + 1;
            int invCount = 0;
            while (leftArrayIndex <= mid && rightArrayIndex <= end)
            {
                if (arr[leftArrayIndex] <= arr[rightArrayIndex])
                {
                    store[storeIndex++] = arr[leftArrayIndex++];
                }
                else
                {
                    invCount += mid - leftArrayIndex + 1;
                    store[storeIndex++] = arr[rightArrayIndex++];
                }
            }
            while (rightArrayIndex <= end)
            {
                store[storeIndex++] = arr[rightArrayIndex++];
            }
            while (leftArrayIndex <= mid)
            {
                store[storeIndex++] = arr[leftArrayIndex++];
            }

            storeIndex = 0;
            for (int i = start; i <= end; i++)
            {
                arr[i] = store[storeIndex++];
            }
            return invCount;
        }
        //not working properly
        public static int InversionCount(int[] arr, int start = 0, int end = -1)
        {
            if (end == -1) end = arr.Length - 1;
            if (start >= end)
                return 0;
            int mid = (start + end) / 2;
            int cl = InversionCount(arr, start, mid);
            int cr = InversionCount(arr, mid + 1, end);
            int cu = InversioncountWhileMerge(arr, start, mid, end);

            return cl + cr + cu;
        }
        //not working
        public static int TernarySearch(int[] arr,int key, int start = 0, int end = -1)
        {
            if (end == -1)
                end = arr.Length - 1;

            if (start <= end)
            {
                int mid1 = start + (end - start) / 3;
                int mid2 = end - (end - start) / 3;
                if (arr[mid1] == key)
                    return mid1;
                if (arr[mid2] == key)
                    return mid2;
                if (key < arr[mid1])
                    return TernarySearch(arr, key, start, mid1-1);
                else if (key > arr[mid2])
                    return TernarySearch(arr, key, mid2+1, end);
                else return TernarySearch(arr,key,mid1,mid2);
            }
            return -1;
        }


    }
}
