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

        public static void Fill<T>(this T[,] array,T with)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = with;
                }
            }
        }
    }
}
