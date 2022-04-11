using DataStructuresPrograms.Code.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Extensions
{
    internal static class ArrayExtensions
    {
        public static void Fill<T>(this T[] originalArray, T with)
        {
            for (int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = with;
            }
        }
        public static void Fill<T>(this T[][] originalArray, T with)
        {
            for (int i = 0; i < originalArray.Length; i++)
            {
                for (int j = 0; j < originalArray[i].Length; j++)
                {
                    originalArray[i][j] = with;
                }
            }
        }

        public static void Fill<T>(this T[,] array, T with)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = with;
                }
            }
        }
        public static int[] Swap(this int[] arr, int i, int j)
        {
            if (i < arr.Length && j < arr.Length && arr[i] != arr[j])
            {
                arr[i] = arr[i] ^ arr[j];
                arr[j] = arr[i] ^ arr[j];
                arr[i] = arr[i] ^ arr[j];
            }
            return arr;
        }

        public static int GetNearestFloorNumber(this int[] arr, int number)
        {
            int start = 0;
            int end = arr.Length - 1;
            int mid = (start + end) / 2;
            while (start < end && start != mid)
            {
                if (arr[mid] > number)
                    end = mid;
                else if (arr[mid] < number)
                    start = mid;

                mid = (start + end) / 2;
            }

            return arr[mid];
        }

        static void Heapify(int[] arr, int lastIndex, int index)
        {
            int max = index;
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            if (left < lastIndex && arr[left] > arr[max])
                max = left;
            if (right < lastIndex && arr[right] > arr[max])
                max = right;
            if (max != index)
            {
                arr.Swap(max, index);
                Heapify(arr, lastIndex, max);
            }
        }
        public static int[] HeapSort(this int[] arr)
        {
            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                arr.Swap(i, 0);
                Heapify(arr, i, 0);
            }
            return arr;
        }

        public static int[] Generate1toN(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
            }
            return arr;
        }

    }
}
