using DataStructuresPrograms.Code.Algo;
using DataStructuresPrograms.Code.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Code.Print
{
    internal static class PrintObject
    {
        internal static void Print(dynamic dynamic)
        {
            Console.WriteLine(dynamic);
        }
        internal static void Print<T>(T[,] arr)
        {
            if (arr != null)
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write($"{arr[i, j]}\t");
                    }
                    Console.WriteLine();
                }
        }
        internal static void Print<T>(T[] arr)
        {
            if (arr != null)
                foreach (T i in arr)
                {
                    Console.Write(i + " ");
                }
            Console.WriteLine();
        }

        internal static void Print<T>(List<T> arr)
        {
            if (arr != null)
                foreach (T i in arr)
                {
                    Console.Write(i + " ");
                }
            Console.WriteLine();
        }

        internal static void Print(Matrix matrix)
        {
            for (int i = 0; i < matrix.RowIndex; i++)
            {
                for (int j = 0; j < matrix.ColumnIndex; j++)
                {
                    Console.Write($"{matrix.Get(i, j)}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        internal static void Print<T, S>(List<KeyValuePair<T, S>> pairs)
        {
            if(pairs!=null)
            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }

        internal static void Print<T, S>(Dictionary<T, S> pairs)
        {
            if (pairs != null)
                foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }

        internal static void Print(params object[] objects)
        {
            foreach (dynamic obj in objects)
            {
                PrintObject.Print(obj);
            }
        }

    }
}
