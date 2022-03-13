using DataStructuresPrograms.Code.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresPrograms.Extensions;

namespace DataStructuresPrograms.Code.Objects
{
    public class Matrix
    {
        double[,] Elements { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
        public Matrix() { Elements = new double[0, 0]; }
        public Matrix(int order) : this(order, order) { }
        public Matrix(int rows, int columns)
        {
            RowIndex = rows;
            ColumnIndex = columns;
            Elements = new double[rows, columns];
        }

        public Matrix(int order, int[,] nums) : this(order) =>  Insert(order,order,nums.ConvertToDouble());
        public Matrix(int order, long[,] nums) : this(order) => Insert(order, order, nums.ConvertToDouble());
        public Matrix(int order, float[,] nums) : this(order) => Insert(order, order, nums.ConvertToDouble());
        public Matrix(int order, double[,] nums) : this(order) => Insert(order, order, nums);
        public Matrix(int rowIndex,int colIndex, int[,] nums) : this(rowIndex,colIndex) => Insert(rowIndex, colIndex, nums.ConvertToDouble());
        public Matrix(int rowIndex, int colIndex, long[,] nums) : this(rowIndex, colIndex) => Insert(rowIndex, colIndex, nums.ConvertToDouble());
        public Matrix(int rowIndex, int colIndex, float[,] nums) : this(rowIndex, colIndex) => Insert(rowIndex, colIndex, nums.ConvertToDouble());
        public Matrix(int rowIndex, int colIndex, double[,] nums) : this(rowIndex, colIndex) => Insert(rowIndex, colIndex, nums);
        public Matrix(int order, int[][] nums) : this(order) => Insert(order, order, nums.ConvertToDouble());
        public Matrix(int order, long[][] nums) : this(order) => Insert(order, order, nums.ConvertToDouble());
        public Matrix(int order, float[][] nums) : this(order) => Insert(order, order, nums.ConvertToDouble());
        public Matrix(int order, double[][] nums) : this(order) => Insert(order, order, nums);
        public Matrix(int rowIndex, int colIndex, int[][] nums) : this(rowIndex, colIndex) => Insert(rowIndex, colIndex, nums.ConvertToDouble());
        public Matrix(int rowIndex, int colIndex, long[][] nums) : this(rowIndex, colIndex) => Insert(rowIndex, colIndex, nums.ConvertToDouble());
        public Matrix(int rowIndex, int colIndex, float[][] nums) : this(rowIndex, colIndex) => Insert(rowIndex, colIndex, nums.ConvertToDouble());
        public Matrix(int rowIndex, int colIndex, double[][] nums) : this(rowIndex, colIndex) => Insert(rowIndex, colIndex, nums);
        public Matrix(int[,] nums) : this(nums.GetLength(0),nums.GetLength(1)) => Insert(nums.ConvertToDouble());
        public Matrix(float[,] nums) : this(nums.GetLength(0), nums.GetLength(1)) => Insert(nums.ConvertToDouble());
        public Matrix(long[,] nums) : this(nums.GetLength(0), nums.GetLength(1)) => Insert(nums.ConvertToDouble());
        public Matrix(double[,] nums) : this(nums.GetLength(0), nums.GetLength(1)) => Insert(nums);
        public Matrix(int[][] nums) : this(nums.GetLength(0), nums.GetLength(1)) => Insert(nums.ConvertToDouble());
        public Matrix(float[][] nums) : this(nums.GetLength(0), nums.GetLength(1)) => Insert(nums.ConvertToDouble());
        public Matrix(long[][] nums) : this(nums.GetLength(0), nums.GetLength(1)) => Insert(nums.ConvertToDouble());
        public Matrix(double[][] nums) : this(nums.GetLength(0), nums.GetLength(1)) => Insert(nums);

        void Insert(int rowIndex,int colIndex, double[,] nums) 
        {
            for (int i = 0; i < rowIndex && i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < colIndex && j < nums.GetLength(1); j++)
                {
                    Elements[i, j] = nums[i, j];
                }
            }
        }

        void Insert(int rowIndex,int colIndex,double[][] nums)
        {
            for (int i = 0; i < rowIndex && i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < colIndex && j < nums.GetLength(1); j++)
                {
                    Elements[i, j] = nums[i][j];
                }
            }
        }

        void Insert(double[][] nums)
        {
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Elements[i, j] = nums[i][j];
                }
            }
        }

        void Insert(double[,] nums)
        {
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Elements[i, j] = nums[i, j];
                }
            }
        }

        public void Set(int i, int j, int value) => Set(i, j, (double)value);

        public void Set(int i, int j, long value) => Set(i, j, (double)value);
    
        public void Set(int i, int j, float value) => Set(i, j, (double)value);
    
        public void Set(int i, int j, double value)
        {
            if (i < 0 || j < 0 || i >= RowIndex || j >= ColumnIndex)
                return;
            Elements[i, j] = value;
        }


        public double Get(int i, int j)
        {
            return Elements[i, j];
        }

        public Matrix Identity(int order)
        {
            RowIndex = order; ColumnIndex = order;
            Elements = new double[RowIndex, ColumnIndex];
            for (int i = 0; i < Elements.GetLength(0); i++)
            {
                Elements[i, i] = 1;
            }
            return this;
        }

        public static Matrix operator *(Matrix first, Matrix second)
        {
            if (first.ColumnIndex != second.RowIndex || first == null || first.Elements == null || second == null || second.Elements == null)
            {
                return null;
            }

            Matrix res = new Matrix(first.RowIndex, second.ColumnIndex);

            for (int i = 0; i < first.RowIndex; i++)
            {
                for (int j = 0; j < second.ColumnIndex; j++)
                {
                    for (int k = 0; k < first.ColumnIndex; k++)
                    {
                        res.Elements[i, j] += first.Elements[i, k] * second.Elements[k, j];
                        res.Elements[i, j] = (int)(res.Elements[i, j] % (1e9 + 7));
                    }
                }
            }
            return res;
        }

        public static Matrix operator +(Matrix first, Matrix second)
        {
            if ((first.RowIndex != second.RowIndex && first.ColumnIndex != second.ColumnIndex) || (first == null || first.Elements == null || second == null || second.Elements == null))
            {
                return null;
            }

            Matrix res = new Matrix(first.RowIndex, second.ColumnIndex);

            for (int i = 0; i < first.RowIndex; i++)
            {
                for (int j = 0; j < first.ColumnIndex; j++)
                {
                    res.Elements[i, j] = first.Elements[i, j] + second.Elements[i, j];
                    res.Elements[i, j] = (int)(res.Elements[i, j] % (1e9 + 7));
                }
            }
            return res;
        }

        public static Matrix operator -(Matrix first, Matrix second)
        {
            if ((first.RowIndex != second.RowIndex && first.ColumnIndex != second.ColumnIndex) || (first == null || first.Elements == null || second == null || second.Elements == null))
            {
                return null;
            }
            Matrix res = new Matrix(first.RowIndex, second.ColumnIndex);

            for (int i = 0; i < first.RowIndex; i++)
            {
                for (int j = 0; j < first.ColumnIndex; j++)
                {
                    res.Elements[i, j] = first.Elements[i, j] - second.Elements[i, j];
                    res.Elements[i, j] = (int)(res.Elements[i, j] % (1e9 + 7));
                }
            }
            return res;
        }

        public static Matrix operator /(Matrix first, double second)
        {
            if (first == null || first.Elements == null || second == 0)
                return null;
            for (int i = 0; i < first.RowIndex; i++)
            {
                for (int j = 0; j < first.ColumnIndex; j++)
                {
                    first.Elements[i, j] /= second;
                }
            }
            return first;
        }
    }

    public static class _Matrix
    {
        public static void Fill(this Matrix matrix, int fillWith)
        {
            for (int i = 0; i < matrix.RowIndex; i++)
            {
                for (int j = 0; j < matrix.ColumnIndex; j++)
                {
                    matrix.Set(i, j, fillWith);
                }
            }
        }

        public static Matrix Transpose(this Matrix matrix)
        {
            Matrix transpose = new Matrix(matrix.RowIndex, matrix.ColumnIndex);
            for (int i = 0; i < matrix.RowIndex; i++)
            {
                for (int j = 0; j < matrix.ColumnIndex; j++)
                {
                    transpose.Set(i, j, matrix.Get(matrix.RowIndex - i - 1, matrix.ColumnIndex - j - 1));
                }
            }
            return transpose;
        }

        public static int Rank(this Matrix matrix)
        {
            return Math.Min(matrix.RowIndex, matrix.ColumnIndex);
        }

        static double? Determinant(this Matrix matrix)
        {
            double determinant = 0;
            if (matrix.RowIndex == 1)
                return (int)matrix.Get(0, 0);
            if (matrix == null || matrix.RowIndex != matrix.ColumnIndex || matrix.RowIndex < 0 || matrix.ColumnIndex < 0) return null;
            int sign = 1;

            for (int i = 0; i < matrix.RowIndex; i++)
            {
                Matrix cofactorMatrix = matrix.GetCofactorMatrix(0, i);            // To store cofactors
                determinant += sign * matrix.Get(0, i) * cofactorMatrix.Determinant().Value;
                sign = -sign;
            }

            return determinant;
        }

        public static Matrix GetCofactorMatrix(this Matrix matrix, int rowIndex, int columnIndex)
        {
            Matrix cofactorMatrix = new Matrix(matrix.RowIndex - 1, matrix.ColumnIndex - 1);
            if (matrix == null || rowIndex >= matrix.RowIndex || columnIndex >= matrix.ColumnIndex)
            {
                return null;
            }
            int ci = 0, i = 0;
            int cj = 0, j = 0;
            while (i < matrix.RowIndex && j < matrix.ColumnIndex)
            {
                if (i != rowIndex && j != columnIndex)
                {
                    cofactorMatrix.Set(ci, cj++, matrix.Get(i, j));
                }
                if (j++ == matrix.ColumnIndex - 1)
                {
                    if (i != rowIndex) ci++;
                    i++;
                    cj = 0;
                    j = 0;
                }
            }
            return cofactorMatrix;
        }

        public static Matrix Adjoint(this Matrix matrix)
        {
            if (matrix == null || matrix.RowIndex != matrix.ColumnIndex)
                return null;
            Matrix adjoint = new Matrix(matrix.RowIndex, matrix.ColumnIndex);

            for (int i = 0; i < matrix.RowIndex; i++)
            {
                for (int j = 0; j < matrix.ColumnIndex; j++)
                {
                    adjoint.Set(i, j, matrix.GetCofactorMatrix(j, i).Determinant().Value);
                    if (((i + j) & 1) != 0)
                        adjoint.Set(i, j, -1 * adjoint.Get(i, j));
                }
            }
            return adjoint;
        }

        public static Matrix Inverse(this Matrix matrix)
        {
            if (matrix == null || matrix.RowIndex != matrix.ColumnIndex)
                return null;
            double determinant = matrix.Determinant().Value;
            if (determinant == 0)
            {
                return null;
            }
            else
            {
                Matrix adjoint = matrix.Adjoint();
                adjoint = adjoint.Transpose();
                adjoint = adjoint / determinant;
                return adjoint;
            }
        }

    }

}
