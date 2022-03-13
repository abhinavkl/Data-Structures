using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Code.Algo
{
    internal class TravellingSales
    {
        internal int tranverse(int[,] list,int n,int visited,int current,int[,] dp)
        {
            if((visited == (1<<n)-1))
            {
                return list[current,0];
            }
            else
            {
                if (dp[visited,current]!=-1) return dp[visited,current];
                else
                {
                    int min = Int32.MaxValue;
                    //remaining paths
                    for (int choice = 0; choice < n; choice++)
                    {
                        //is city visited
                        if ((visited & 1 << choice) == 0) //not visited
                        {

                            int subSol = list[current, choice] + tranverse(list, n, (visited | 1 << choice), choice, dp);
                            min = Math.Min(min, subSol);
                        }
                    }
                    dp[visited,current] = min;
                    return min;
                }
            }
        }
    }
}
