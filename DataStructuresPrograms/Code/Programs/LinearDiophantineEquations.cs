using DataStructuresPrograms.Code.Basic;
using DataStructuresPrograms.Code.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Code.Programs
{
    internal class LinearDiophantineEquations
    {
        public static int[] Solution(int a, int b, int c)
        {
            int[] soln = MathOperations.ExtEuclidean(a,b);
            int[] lde = new int[2];
            if (c% soln[2]==0)
            {
                int k = c / soln[2];
                lde[0] = k * soln[0];
                lde[1] = k * soln[1];
            }
            return lde;
        }
    }
}
