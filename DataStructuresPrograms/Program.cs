using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresPrograms.Code.Print;
using DataStructuresPrograms.Extensions;
using DataStructuresPrograms.Code.Objects;
using System.Text.RegularExpressions;
using DataStructuresPrograms.Code.Algo;
using DataStructuresPrograms.Code.Basic;
using DataStructuresPrograms.Code.Programs;
using DataStructuresPrograms.DS.Arrays;
using DataStructuresPrograms.DS.Sorting;

namespace DataStructuresPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Advanced DS
            #region travelling sales person
            //int[,] travellingSales = new int[4,4] {
            //{ 0, 20, 42, 25 },
            //{ 20, 0, 30, 34 },
            //{ 42, 30, 0, 10 },
            //{ 25, 34, 10, 0 }
            //};
            ////PrintObject pl=new PrintObject();
            //int[,] dpTs = new int[1<<travellingSales.GetLength(0), travellingSales.GetLength(0)];
            //dpTs.Fill(-1);
            //TravellingSales tsales=new TravellingSales();
            //Console.WriteLine(tsales.tranverse(travellingSales, travellingSales.GetLength(0), 0, 0,dpTs));
            #endregion
            #region xor encode decode
            //int[] encoded = new int[] { 1,2,3};
            //XorOperations xorOperations = new XorOperations();
            //PrintObject pl=new PrintObject();
            //pl.Print(xorOperations.Decode(encoded));
            #endregion
            #region BigIntegers Integer Array
            //BigInteger bigInteger1 = new BigInteger() { Integer = new int[] { -8, 9 } };
            //BigInteger bigInteger2 = new BigInteger() { Integer = new int[] { 9, 7, 8 } };
            //BigInteger bigInteger3 = new BigInteger() { Integer = new int[] { -9, 1, 0, 0 } };
            //BigInteger.Add(bigInteger1, bigInteger2, bigInteger3);
            #endregion
            #region BigIntegers String
            /*BigInteger integer1 = new BigInteger("-89");
            BigInteger integer2 = new BigInteger("978");
            BigInteger integer3 = new BigInteger("-81911");
            BigInteger integer4 = new BigInteger("021");
            Console.WriteLine(BigInteger.Add(integer1, integer2, integer3,integer4).Int);
*/

            //BigInteger integer1 = new BigInteger("-990");
            //BigInteger integer2 = new BigInteger("-90");
            //BigInteger integer3 = new BigInteger("-0999");
            ////BigInteger.Multiply(integer1, integer2, integer3);
            ////3,5,6
            ////Console.WriteLine(BigInteger.Multiply(integer1, integer2, integer3).Int);

            //BigInteger factinteger = new BigInteger("100");
            ////Console.WriteLine(BigInteger.Substract(new BigInteger("100"),new BigInteger("1")).Int);
            //Console.WriteLine(BigInteger.Factorial(factinteger).Int);
            #endregion
            #region MathOperations
            //Console.WriteLine(MathOperations.Multiply(100,100));
            //Console.WriteLine(MathOperations.Power(100,100));
            //Console.WriteLine(Fibonacci.NthDigit(5));
            #endregion
            #region Basic Matrix 
            /*            Matrix matrix = new Matrix(3, 3);
                        matrix.Set(0, 0,1);
                        matrix.Set(0, 1,1);
                        matrix.Set(0, 2,2);
                        matrix.Set(1, 0,3);
                        matrix.Set(1, 1,4);
                        matrix.Set(1, 2,5);
                        matrix.Set(2, 0,1);
                        matrix.Set(2, 1,2);
                        matrix.Set(2, 2,3);
                        PrintObject.Print(matrix);
                        matrix.Transpose();
                        PrintObject.Print(matrix);*/

            //Sum of Fibonacci  S(m between n)= F(m) - F(n-1)  [i]approach
            //                  [[1,1,1],[0,1,1],[0,1,0]] 

            //Console.WriteLine(Fibonacci.Sum(5));
            //Console.WriteLine(Fibonacci.SumRange(4,6));
            #endregion
            #region tree
            //Tree tree = new Tree();
            ////1 2 3
            ////2 3 2
            ////4 3 2
            //tree.AddRoute(1,2,3);
            //tree.AddRoute(2,3,2);
            //tree.AddRoute(4,3,2);
            //long ans = 0;
            //tree.MaxAllTranversals(1, -1, tree.Nodes.Count, ref ans);
            //Console.WriteLine(ans);
            #endregion
            #region Subarray sum devisible by array size
            //int[] arr = new int[] { 4, 5, 0, 4, 2 };
            //int n = arr.Length;
            //int i = 1;
            //while (i < n)
            //{
            //    arr[i] += arr[i - 1];
            //    arr[i] %= n;
            //    i++;
            //}

            //int output = 0;

            //Dictionary<int, int> store = new Dictionary<int, int>();

            //foreach (var ele in arr)
            //{
            //    if (store.ContainsKey(ele))
            //        store[ele]++;
            //    else store[ele] = 1;
            //}

            //output = store.Where(e => e.Value != 1).Sum(s => s.Value);

            //if (store.ContainsKey(0))
            //    output++;
            #endregion
            #region Array Rotation
            //int[] arr = new int[] { 12,18,56,45,23,67,90,34};  //5,8,7,4,3,2,1,6
            //Console.WriteLine(string.Join(", ", arr));
            ////arr.RotateLeftUnSorted(3);
            ////arr.RotateLeftUnSorted(8);
            //Console.WriteLine(string.Join(", ", arr.RotateLeftUnSorted(5)));
            #endregion
            #region Devisiors till N
            //Console.WriteLine(NumberOperations.TotalDevisors(10,10));
            //Console.WriteLine(NumberOperations.TotalDevisors(579000,987654,new int[] { 1,2}));
            #endregion
            #region prime seive
            //int n = 50;
            //PrintObject.Print(NumberOperations.PrimeSieve(n));
            #endregion
            #region prime factorisation
            //PrintObject.Print(NumberOperations.PrimeFactorisation(99));
            //PrintObject.Print(NumberOperations.PrimeFactorisationSieve(99));
            //NumberOperations.PrimeSegmentedSieve(200,250);
            #endregion
            #region Alice and Candies
            //AliceAndCandies.Solution(45);
            #endregion
            #region coprimes
            //Coprimes.Soultion(30);
            #endregion
            #region Extended Euclidean
            //ax+by=GCD(a,b) solve x and y
            //PrintObject.Print(MathOperations.ExtEuclidean(41,97));
            #endregion
            #region Multiplication Modulo inverse
            //(a * x)%m=1
            //PrintObject.Print(MatrixMultiplicationInverse.Solution(6,7));
            #endregion
            #region Linear Diophantine Equation
            //PrintObject.Print(LinearDiophantineEquations.Solution(18,30,240));
            #endregion
            #region GCDString
            //GCDStrings.Solution(2,"123");
            #endregion
            #region Backtracing
            //Backtracing.SubSets("abhi");
            //Backtracing.SubSets("abhi", "");
            #endregion
            #region Backtracing programs
            //Backtracing.Permutaion("abhi");
            //Backtracing.GetBrackets(3);
            //Backtracing.NQueen(8,null,0);
            //PrintObject.Print(Backtracing.NQueenSolution(8,new int[8,8],0));
            //PrintObject.Print(Backtracing.TargetSum(new int[] { 1,1,1,1,1},3));
            /*Backtracing.SudokuSoln(new int[9, 9] {{5,3,0,0,7,0,0,0,0 },
                                                  {6,0,0,1,9,5,0,0,0 },
                                                  {0,9,8,0,0,0,0,6,0 },
                                                  {8,0,0,0,6,0,0,0,3 },
                                                  {4,0,0,8,0,3,0,0,1 },
                                                  {7,0,0,0,2,0,0,0,6 },
                                                  {0,6,0,0,0,0,2,8,0 },
                                                  {0,0,0,4,1,9,0,0,5 },
                                                  {0,0,0,0,8,0,0,7,0 }});
            */

            //Backtracing.PowerSum(45,2);
            //Backtracing.NextPermutation("13542");
            #endregion
            #region Binary Search
            //BinarySearch.FindFrequency(new int[] { 1,1,1,2,2,2,3,3,3,4,4,4,4,5,5,5,5,5,6,6,6,6 },4);
            //BinarySearch.MinimumDistanceAngryBirds(new int[] { 1, 2, 4, 8, 9 }, 3);
            //Console.WriteLine(BinarySearch.GameOfGreed(new int[] { 31,40,12,20 },3));
            //Console.WriteLine(BinarySearch.IsPerfectSquare(16));
            //Console.WriteLine(BinarySearch.GetMinimumAttempts(7,14,3,8));
            #endregion
            #region Divide n Conquer
            //PrintObject.Print((new int[] { 2,3,7,5,9,1,6,4,8,10 }.MergeSort()));
            //PrintObject.Print(new int[] { 2, 3, 7, 4, 1, 6, 8, 5 }.QuickSort());
            //PrintObject.Print(new int[] { 10,5,2,0,7,6,4}.QuickSelectPosition(5));
            //PrintObject.Print((new int[] { 2,4,3,5,1}.InversionCount()));
            //PrintObject.Print(new int[] { 9, 8, 6, 4, 2, 0, 1, 3, 5, 7,10 }.TernarySearch(1));
            #endregion
            #region Greedy
            //Greedy.CoinsExchange(1273);
            #endregion
            #region Sorting
            //PrintObject.Print(new List<int> { 5,6,1,2,8,3,10,4,7,9 }.HeapSort());
            //PrintObject.Print(new int[] { 5,6,1,2,8,3,10,4,7,9 }.HeapSort());
            //new List<int> { 5, 6, 1, 2, 8, 3, 10, 4, 7, 9 }.GetTopKElements(5);
            //new List<int> { 5, 6, 1, 2, 8, 3, 10, 4, 7, 9 }.GetLeastKElements(5);
            //int[] arr = ArrayExtensions.Generate1toN(20);
            //arr.Rotate(12);
            #endregion

            #endregion

            #region DS
            #region Arrays
            ArrayPrograms.Run();
            #endregion

            #region Sorting
            Sorter.Run();
            #endregion

            #endregion


            #region
            #endregion

        }
    }
}
