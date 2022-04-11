using DataStructuresPrograms.Code.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresPrograms.Extensions;
using DataStructuresPrograms.Code.Objects;

namespace DataStructuresPrograms.Code.Basic
{
    internal class Backtracing
    {
        static int counter = 0;
        public static void SubSets(string str, char[] print = null, int strIndex = 0, int printIndex = 0)
        {
            if (print == null)
                print = new char[str.Length];
            if (str.Length == strIndex)
            {
                Console.WriteLine(String.Join("", (print.Take(printIndex))));
                return;
            }
            print[printIndex] = str[strIndex];
            SubSets(str, print, strIndex + 1, printIndex + 1);
            SubSets(str, print, strIndex + 1, printIndex);

        }

        public static void SubSets(string str, string output)
        {
            if (str.Length == 0)
            {
                Console.WriteLine(output);
                return;
            }
            SubSets(str.Substring(1), output + str[0]);
            SubSets(str.Substring(1), output);
        }

        /*public static void NextKthCombination(int n)
        {
            int iterator = 0;
            int firstZero = -1;
            int secondZero = -1;
            int nextCombination = 0;
            int pow = 1;
            while (n != 0)
            {
                int curBit = (n & 1);
                if (curBit == 0)
                {
                    if (firstZero == -1)
                    {
                        firstZero = iterator;
                    }
                    else if (secondZero == -1)
                    {
                        secondZero = iterator;
                    }
                }
                iterator++;
                n = n / 2;
            }
            int tmp = iterator;

            while (iterator-- > 0)
            {
                if (firstZero == 0 && secondZero == 1)
                    nextCombination = -1;
                else
                {
                    if (firstZero == 0)
                    {
                        secondZero = secondZero - 1;
                        firstZero = secondZero - 1;
                    }
                    else
                    {
                        firstZero = firstZero - 1;
                    }
                }
            }
            iterator = 0;
            if (nextCombination != -1)
            {
                while (iterator < tmp)
                {
                    nextCombination += (pow * ((iterator == firstZero || iterator == secondZero) ? 0 : 1));
                    pow *= 2;
                    iterator++;
                }
            }

            Console.WriteLine(firstZero + " " + secondZero + " " + nextCombination);

        }
*/

        public static void Permutaion(string str, int start = 0, int end = 0)
        {
            if (end == 0)
                end = str.Length - 1;
            if (start == end)
            {
                Console.WriteLine(str);
                return;
            }

            for (int i = start; i <= end; i++)
            {
                Permutaion(str.Swap(i, start), start + 1, end);
            }
        }

        public static void GetBrackets(int n, string brackets = "", int open = 0, int close = 0)
        {
            if (brackets.Length == 2 * n)
            {
                Console.WriteLine(brackets);
                return;
            }
            else
            {
                if (close < open)
                {
                    GetBrackets(n, brackets + ")", open, close + 1);
                }
                if (open < n)
                {
                    GetBrackets(n, brackets + "(", open + 1, close);
                }
            }
        }

        static int IsSafe(int n, int[] board, int curRow)
        {
            int i = 0;
            Dictionary<int, int> prevPlaces = new Dictionary<int, int>();
            for (i = 0; i < curRow; i++)
            {
                prevPlaces.Add(i, board[i]);
            }
            Dictionary<int, int> prevPlacesMaths = new Dictionary<int, int>();
            prevPlaces.ToList().ForEach(k =>
            {
                prevPlacesMaths.Add(k.Key + k.Value, k.Key - k.Value);
            });

            for (i = (board[curRow] == -1 ? 0 : board[curRow]); i < n; i++)
            {
                if (prevPlaces.ContainsValue(i) || prevPlacesMaths.ContainsKey(i + curRow) || prevPlacesMaths.ContainsValue(curRow - i))
                    continue;
                else break;
            }
            board[curRow] = i >= n ? -1 : i;
            prevPlaces.Clear();
            prevPlacesMaths.Clear();
            return board[curRow];
        }

        public static void NQueen(int n, int[] board = null, int curRow = 0)
        {
            if (n % 4 != 0)
            {
                Console.WriteLine("Cannot solve this problem");
                return;
            }
            if (curRow == n)
            {
                PrintObject.Print(board);
                if (board[0] >= n - 1)
                    return;
                int temp = board[0];
                board.Fill(-1);
                board[0] = temp + 1;
                NQueen(n, board, 0);
            }
            else
            {
                if (board == null)
                {
                    board = new int[n];
                    board.Fill(-1);
                }
                List<int[]> soln = new List<int[]>();
                var possible = IsSafe(n, board, curRow);
                if (possible != -1)
                {
                    board[curRow] = possible;
                    NQueen(n, board, curRow + 1);
                }
                else
                {
                    if (curRow == 0)
                        return;
                    board[curRow - 1] = board[curRow - 1] + 1;
                    NQueen(n, board, curRow - 1);
                }
            }
        }

        static bool canPlace(int[,] board, int n, int row, int col)
        {
            for (int k = 0; k < row; k++)
            {
                if (board[k, col] == 1)
                    return false;
            }

            int i = row;
            int j = col;
            while (i >= 0 && j >= 0)
            {
                if (board[i, j] == 1)
                    return false;
                i--; j--;
            }

            i = row;
            j = col;
            while (i >= 0 && j < n)
            {
                if (board[i, j] == 1)
                    return false;
                i--; j++;
            }
            return true;

        }
        public static int NQueenSolution(int n, int[,] board, int curRow)
        {
            if (curRow == n)
            {
                Console.WriteLine();
                PrintObject.Print(board);
                return 1;
            }
            int ways = 0;
            for (int i = 0; i < n; i++)
            {
                //is cur pos safe ?
                if (canPlace(board, n, curRow, i))
                {
                    board[curRow, i] = 1;
                    ways += NQueenSolution(n, board, curRow + 1);
                    board[curRow, i] = 0;

                }
            }
            return ways;
        }


        public static int TargetSum(int[] arr, int target, int level = 0, int curSum = 0)
        {
            if (level == arr.Length)
            {
                if (curSum == target)
                    counter++;
                return curSum == target ? 1 : 0;
            }
            TargetSum(arr, target, level + 1, curSum + arr[level]);
            TargetSum(arr, target, level + 1, curSum - arr[level]);
            return counter;
        }

        public static bool IsSudokuSolvable(int[,] sudoku, int curRow, int curCol, int value)
        {
            for (int index = 0; index < sudoku.GetLength(0); index++)
            {
                int quo = (index) / 3;
                int rem = (index) % 3;
                int centerx = (curRow / 3)*3;
                int centery = (curCol / 3)*3;
                if (sudoku[index, curCol] == value || sudoku[curRow, index] == value || sudoku[centerx + quo, centery + rem] == value)
                    return false;
            }
            return true;
        }
        public static bool SudokuSoln(int[,] sudoku, int curRow = 0, int curCol = 0)
        {
            if (curRow == sudoku.GetLength(0)-1 && curCol==sudoku.GetLength(0))
            {
                PrintObject.Print(sudoku);
                return true;
            }
            if (curCol == sudoku.GetLength(0))
            {
                curCol = 0;
                curRow = curRow + 1;
            }

            if (sudoku[curRow, curCol] == 0)
            {
                for (int value = 1; value <= sudoku.GetLength(0); value++)
                {

                    if (IsSudokuSolvable(sudoku, curRow, curCol, value))
                    {
                        sudoku[curRow, curCol] = value;
                        if (SudokuSoln(sudoku, curRow, curCol + 1))
                            return true;
                        sudoku[curRow, curCol] = 0;
                    }
                }

            }
            else SudokuSoln(sudoku,curRow,curCol+1);
            return false;
        }


        public static bool IsPalindrome(string str,int first=0,int second=0)
        {
            if (first == 0 && second == 0)
                second = str.Length - 1;
            if (first >= second)
                return true;
            return str[first]==str[second] && IsPalindrome(str,first+1,second-1);
        }


        static int PowerSumSolution(int[] powers,int curIndex,int curSum,int target)
        {
            if (curSum > target || curIndex == powers.Length)
                return 0;
            if (curSum == target)
            {
                Console.WriteLine((curIndex -1)+ " "+curSum);
                return 1;
            }
            int sol = 0;
            sol+=PowerSumSolution(powers, curIndex + 1, curSum, target);
            sol+=PowerSumSolution(powers,curIndex+1,curSum+powers[curIndex],target);
            return sol;
        }

        public static void PowerSum(int n,int k,int rem=0,int target=-1)
        {
            if (target == -1) target = n;
            int max = (int)MathOperations.NegativePower(n,k);
            int[] powers = new int[max+1];
            for(int i = 0; i <= max; i++)
            {
                powers[i] = (int)Math.Pow(i,k);
            }
            PrintObject.Print(powers);
            int soln = PowerSumSolution(powers, 1, 0, target);
            if (powers[max] == target)
                soln++;
            Console.WriteLine(soln);
        }

        public static string NextPermutation(string str)
        {
            int index = -1;
            for(int i=str.Length-1;i>0;i--)
            {
                if(str[i]>str[i-1])
                {
                    index = i-1;
                    break;
                }
            }
            if (index == -1)
                return "";

            int nextGreaterElementIndex = -1;
            for(int i = str.Length - 1; i > index; i--)
            {
                if (str[i] > str[index])
                {
                    nextGreaterElementIndex = i;
                    break;
                }                
            }
            str = str.Swap(index,nextGreaterElementIndex);
            str = str.Reverse(index+1,str.Length-1);
            return str;
        }

    }
}
