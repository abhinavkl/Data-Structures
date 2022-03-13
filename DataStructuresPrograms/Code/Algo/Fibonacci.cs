using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Code.Objects
{
    internal class Fibonacci
    {
        //matrix approach
        const int mod = (int)1e9 + 7;
        public static int NthDigit(int n)
        {
            Matrix identity = new Matrix();
            identity.Identity(2);

            Matrix multiplier=new Matrix(new int[2,2] {
                { 1,1 },
                { 1,0 } 
            });
            
            if (n<2) return 1;
            n -= 2;
            while (n > 0)
            {
                if ((n & 1) != 0)
                    identity = identity * multiplier;
                multiplier=multiplier * multiplier;
                n /= 2;
            }


            return (int)((identity.Get(0, 0) + identity.Get(0, 1)) %mod);
        }

        //matrix approach
        //S(n)=F(n+2)-1
        public static int Sum(int n)
        {
            Matrix res= new Matrix();
            res.Identity(3);
            Matrix multiplier = new Matrix(new int[3, 3] { 
                { 1,1,1 },
                { 0,1,1 },
                { 0,1,0 } 
            });
            if (n == 1) return n;
            if(n==-1 || n==0) return 0;
            n -= 1;
            while (n > 0)
            {
                if ((n & 1) != 0)
                    res = res * multiplier;
                multiplier = multiplier * multiplier;
                n /= 2;
            }
            return (int)((res.Get(0, 0) + res.Get(0, 1)) % mod);
        }

        public static int SumRange(int m,int n)
        {
            if (m > n)
                return SumRange(n,m);

            if(m ==0 || n==0)
                return 0;

            if (m < 0)
                return -1;

          // return (Sum(n) - Sum(m-1)+mod)%mod;
          return (NthDigit(n+2)-NthDigit(m+1)+mod)%mod;
        }

    }
}
