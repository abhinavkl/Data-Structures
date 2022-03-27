using DataStructuresPrograms.Code.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresPrograms.Extensions;

namespace DataStructuresPrograms.Code.Basic
{
    internal class Backtracing
    {
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

        public static void Permutaion(string str,int start=0,int end=0)
        {
            if (end == 0)
                end = str.Length-1;
            if (start == end)
            {
                Console.WriteLine(str);
                return;
            }

            for(int i = start; i <= end; i++)
            {
                Permutaion(str.Swap(i, start), start+1,end);
            }
        }

        public static void GetBrackets(int n,string brackets="",int open=0,int close=0)
        {
            if (brackets.Length == 2*n)
            {
                Console.WriteLine(brackets);
                return;
            }
            else
            {
                if (close<open)
                {
                    GetBrackets(n,brackets+")",open,close+1);
                }
                if (open < n)
                {
                    GetBrackets(n,brackets+"(",open+1,close);
                }
            }
        }

        static int IsSafe(int n,int[] board,int curRow)
        {
            int i = 0;
            Dictionary<int,int> prevPlaces = new Dictionary<int,int>();
            for(i = 0; i < curRow; i++)
            {
                prevPlaces.Add(i, board[i]);
            }
            Dictionary<int, int> prevPlacesMaths = new Dictionary<int, int>();
            prevPlaces.ToList().ForEach(k => {
                prevPlacesMaths.Add(k.Key+k.Value,k.Key-k.Value);
            });

            for(i = (board[curRow]==-1?0:board[curRow]); i < n; i++)
            {
                if (prevPlaces.ContainsValue(i) || prevPlacesMaths.ContainsKey(i+curRow) || prevPlacesMaths.ContainsValue(curRow-i))
                    continue;
                else break;
            }
            board[curRow] = i>=n?-1:i;
            prevPlaces.Clear();
            prevPlacesMaths.Clear();
            return board[curRow];
        }

        public static void NQueen(int n,int[] board=null,int curRow=0)
        {
            if (n % 4 != 0)
            {
                Console.WriteLine("Cannot solve this problem");
                return;
            }
            if (curRow == n)
            {
                PrintObject.Print(board);
                if (board[0]>=n-1)
                       return;
                int temp = board[0];
                board.Fill(-1);
                board[0] = temp + 1;
                NQueen(n,board,0);
            }
            else
            {
                if (board == null)
                {
                    board = new int[n];
                    board.Fill(-1);
                }
                List<int[]> soln = new List<int[]>();
                var possible = IsSafe(n,board,curRow);
                if (possible!=-1)
                {
                    board[curRow] = possible;
                    NQueen(n,board,curRow+1);
                }
                else
                {
                    if (curRow == 0)
                        return;
                    board[curRow - 1] = board[curRow - 1] + 1;
                    NQueen(n,board,curRow-1);
                }
            }
        }

        static bool canPlace(int[,] board,int n,int row,int col)
        {
            for(int k = 0; k < row; k++)
            {
                if (board[k, col] == 1)
                    return false;
            }

            int i = row;
            int j = col;
            while(i>=0 && j >= 0)
            {
                if (board[i, j] == 1)
                    return false;
                i--;j--;
            }

            i = row;
            j = col;
            while(i>=0 && j < n)
            {
                if (board[i, j] == 1)
                    return false;
                i--;j++;
            }
            return true;

        }
        public static bool NQueenSolution(int n,int[,] board,int curRow)
        {
            if(curRow==n)
            {
                PrintObject.Print(board);
                return true;
            }
            for(int i = 0; i < n; i++)
            {
                //is cur pos safe ?
                if (canPlace(board, n, curRow, i))
                {
                    board[curRow, i] = 1;
                    bool success = NQueenSolution(n,board,curRow+1);
                    if (success)
                    {
                        return true;
                    }
                    board[curRow, i] = 0;

                }
            }
            return false;
        }
        









    }
}
