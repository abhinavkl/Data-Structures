using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresPrograms.Code.Algo;
using DataStructuresPrograms.Code.Print;

namespace DataStructuresPrograms.Code.Basic
{
    internal static class MathOperations
    {
        public static int MultiplyEach(int eachCount,params int[] nums)
        {
            var allSum = 0;
            if (nums.Length == 0)
                return 1;
            else if (nums.Length == 1)
                return nums[0];
            else if (nums.Length == 2)
                return nums[0] * nums[1];
            else
            {

                List<int> productIndexes = Combinations.Generate(nums.Count(), eachCount);

                for (int i = 0; i < productIndexes.Count; i++)
                {
                    var curProd = 1;
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if ((productIndexes[i] & (1 << j)) != 0)
                        {
                            curProd *= nums[j];
                        }
                    }
                    allSum += curProd;
                }
            }
            return allSum;
        }
        public static int MultiplyEach(int eachCount,List<int> nums)
        {
            var allSum = 0;
            if (nums.Count == 0)
                return 1;
            else if (nums.Count == 1)
                return nums[0];
            else if (nums.Count == 2)
                return nums[0] * nums[1];
            else {

                List<int> productIndexes = Combinations.Generate(nums.Count(), eachCount);

                for(int i = 0; i < productIndexes.Count; i++)
                {
                    var curProd = 1;
                    for(int j = 0; j < nums.Count; j++)
                    {
                        if((productIndexes[i] & (1 << j)) != 0)
                        {
                            curProd*=nums[j];
                        }
                    }
                    allSum+=curProd;
                }
            }
            return allSum;
        }

        public static int Factorial(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            else return n * Factorial(n - 1);
        }

        static int Multiply(int a,int b,int mod)
        {
            int res = 0;
            while (b > 0)
            {
                if ((b & 1) != 0)
                {
                    res = res + a; res %= mod;
                }
                a += a; a = a % mod;
                b = b >> 1;
            }
            return res;
        }
        public static int Multiply(int a,int b)
        {
            return Multiply(a,b,(int)1e9 + 7);
        }

        static int Power(int a, int b, int mod)
        {
            int res = 0;
            while (b > 0)
            {
                if ((b & 1) != 0)
                {
                    res = res + a; res %= mod;
                }
                a *= a; a = a % mod;
                b = b >> 1;
            }
            return res;
        }

        public static int Power(int a,int b)
        {
            return Power(a,b,(int)1e9+7);
        }

        public static int GCD(int a, int b)
        {
            if (a == 0)
                return b;
            if (a > b)
                return GCD(b, a);
            else return GCD(b % a, a);
        }

        public static int HCF(int a,int b)
        {
            if (a == 0 || b == 0)
                return 0;
            int prod = a * b;
            return prod / GCD(a,b);
        }

        //ax+by=GCD(a,b)
        public static int[] ExtEuclidean(int a,int b)
        {
            int[] xy = new int[3];
            if (b == 0)
            {
                xy[0] = 1;
                xy[1] = 0;
                xy[2] = a;
            }
            else {
                xy = ExtEuclidean(b,a%b);
                int temp = xy[0];
                xy[0] = xy[1];
                xy[1] =temp- (a/b)*xy[0];
            }
            return xy;
        }

        public static double Log(double n,double bse)
        {
            return (Math.Log(n) / Math.Log(bse));
        }

        public static double NegativePower(double bse,double pow)
        {
            return Math.Pow(bse, Math.Pow(pow, -1));
        }


    }
}
