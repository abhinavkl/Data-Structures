using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresPrograms.Code.Print;
using DataStructuresPrograms.Code.Objects;
using System.Text.RegularExpressions;
using DataStructuresPrograms.Code.Algo;
using DataStructuresPrograms.Code.Basic;
using DataStructuresPrograms.Code.Programs;

namespace DataStructuresPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Backtracing.SudokuSoln(new int[9, 9] {{5,3,0,0,7,0,0,0,0 },
                                                  {6,0,0,1,9,5,0,0,0 },
                                                  {0,9,8,0,0,0,0,6,0 },
                                                  {8,0,0,0,6,0,0,0,3 },
                                                  {4,0,0,8,0,3,0,0,1 },
                                                  {7,0,0,0,2,0,0,0,6 },
                                                  {0,6,0,0,0,0,2,8,0 },
                                                  {0,0,0,4,1,9,0,0,5 },
                                                  {0,0,0,0,8,0,0,7,0 }
            });
            #endregion


        }
    }
}
