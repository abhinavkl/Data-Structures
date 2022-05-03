using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Extensions
{
    internal static class PrimitiveExtensions
    {
        public static double[,] ConvertToDouble(this int[,] nums)
        {
            double[,] temp=new double[nums.GetLength(0),nums.GetLength(1)];
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    temp[i,j]=(double)(nums[i,j]);
                }
            }
            return temp;
        }

        public static double[,] ConvertToDouble(this float[,] nums)
        {
            double[,] temp = new double[nums.GetLength(0), nums.GetLength(1)];
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    temp[i, j] = (double)(nums[i, j]);
                }
            }
            return temp;
        }

        public static double[,] ConvertToDouble(this long[,] nums)
        {
            double[,] temp = new double[nums.GetLength(0), nums.GetLength(1)];
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    temp[i, j] = (double)(nums[i, j]);
                }
            }
            return temp;
        }

        public static double[,] ConvertToDouble(this int[][] nums)
        {
            double[,] temp = new double[nums.GetLength(0), nums.GetLength(1)];
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    temp[i, j] = (double)(nums[i][j]);
                }
            }
            return temp;
        }

        public static double[,] ConvertToDouble(this float[][] nums)
        {
            double[,] temp = new double[nums.GetLength(0), nums.GetLength(1)];
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    temp[i, j] = (double)(nums[i][j]);
                }
            }
            return temp;
        }

        public static double[,] ConvertToDouble(this long[][] nums)
        {
            double[,] temp = new double[nums.GetLength(0), nums.GetLength(1)];
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    temp[i, j] = (double)(nums[i][j]);
                }
            }
            return temp;
        }
    }
}
