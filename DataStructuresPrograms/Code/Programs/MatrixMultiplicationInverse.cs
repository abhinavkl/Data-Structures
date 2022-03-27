using DataStructuresPrograms.Code.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Code.Programs
{
    internal class MatrixMultiplicationInverse
    {
        //(a * x)%m=1 : solve x for given a & m
        public static int Solution(int a,int mod)
        {
            int soln = MathOperations.ExtEuclidean(a,mod)[0];
            soln = (soln + mod) & mod;
            return soln;
        }



    }
}
