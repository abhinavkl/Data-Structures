using DataStructuresPrograms.Code.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Code.Basic
{
    internal static class NumberOperations
    {
        public static int[] GetPrimes(int n)
        {
            List<int> primes = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if (!primes.Any(k => i % k == 0))
                    primes.Add(i);
            }
            return primes.ToArray();
        }

        public static int[] GetNPrimes(int n)
        {
            List<int> primes=new List<int>();
            int i = 0,j=2;
            while (i++ < n)
            {
                while (primes.Any(k => j % k == 0))
                    j++;
                primes.Add(j++);
            }
            return primes.ToArray();
        }

        public static int TotalDevisors(int n)
        {
           return TotalDevisors(n,n);
        }

        public static int TotalDevisors(int n,int noOfPrimes)
        {
            int ans = 0;
            int[] primes = GetNPrimes(noOfPrimes);
            for (int i = 1; i < (1 << noOfPrimes); i++)
            {
                int lcm = 1;
                for (int j = 0; j < noOfPrimes; j++)
                {
                    if ((i >> j & 1) != 0)
                    {
                        lcm *= primes[j];
                    }
                }

                if ((BinaryOperations.CountNoOfOne(i) % 2) == 0)
                {
                    ans -= (n / lcm);
                }
                else
                {
                    ans += (n / lcm);
                }
            }

            return ans;
        }

        public static int TotalDevisors(int n,int[] arr)
        {
            int ans = 0;
            int k=arr.Length;
            for (int i = 1; i < (1 << k); i++)
            {
                int hcf = 0;
                List<int> curElements = new List<int>();
                for (int j = 0; j < k; j++)
                {
                    if ((i >> j & 1) != 0)
                    {
                        curElements.Add(arr[j]);
                    }
                }

                if(curElements.Count >= 1)
                hcf = curElements[0];

                if(curElements.Count > 1)
                {
                    for(int m = 0; m < curElements.Count; m++)
                    {
                        hcf=MathOperations.HCF(hcf, curElements[m]);
                    }
                }

                if ((BinaryOperations.CountNoOfOne(i) % 2) == 0)
                {
                    ans -= (n / hcf);
                }
                else
                {
                    ans += (n / hcf);
                }
            }
            return ans;
        }

        public static int TotalDevisors(int start,int end,int[] arr)
        {
            int startDivisorsCount = TotalDevisors(start-1,arr);
            int endDivisorsCount = TotalDevisors(end, arr);
            return endDivisorsCount - startDivisorsCount;
        }

        public static List<long> PrimeSieve(int n)
        {
            int[] nonPrimes=new int[n];
            List<long> primes = new List<long>();

            for(long i = 2; i < n; i++)
            {
                if (nonPrimes[i]==0)
                {
                    primes.Add(i);
                }
                for(long j= i * i; j < n; j = j + i)
                {
                    if (nonPrimes[j]==0)
                    {
                        nonPrimes[j] = 1;
                    }
                }
            }
            /*int countPrimes = 0;
            for (long i = 2; i < n; i++) //for prime queires
            {
                if (nonPrimes[i] == 0)
                    countPrimes++;
                nonPrimes[i] = countPrimes;

            }*/
            return primes;
        }

        public static List<KeyValuePair<int,int>> PrimeFactorisation(int n)
        {
            int sqrt = (int)Math.Sqrt(n);
            int[] primes = GetPrimes(sqrt);

            List<KeyValuePair<int, int>> factorisation = new List<KeyValuePair<int, int>>();

            for(int i = 0; i < primes.Length; i++)
            {
                int curfactorsCount = 0;
                if (n % primes[i]==0)
                {
                    do
                    {
                        n = n / primes[i];
                        curfactorsCount++;
                    } while (n % primes[i] == 0) ;
                }
                if (curfactorsCount > 0)
                    factorisation.Add(new KeyValuePair<int, int>(primes[i],curfactorsCount));
            }
            if (n != 1)
                factorisation.Add(new KeyValuePair<int, int>(n, 1));

            return factorisation;
        }

        public static Dictionary<int, int> PrimeFactorisationSieve(int n)
        {
            int[] sieves=new int[n+1];
            Dictionary<int,int> pairs = new Dictionary<int, int>();
            for(int i = 2; i <= n; i++)
            {
                if(sieves[i]==0)
                {
                    sieves[i] = i;
                    for(int j = i * i; j <= n; j = j + i)
                    {
                        if(sieves[j]==0)
                            sieves[j] = i;
                    }
                }
            }
            while (n != 1) //n!=1 && n!=0
            {
                int index = 0;
                bool found= pairs.TryGetValue(sieves[n], out index);
                if(found)
                    pairs.Remove(sieves[n]);
                pairs.Add(sieves[n], index + 1);
                n = n / sieves[n];
            }
            return pairs;
        }
        public static void PrimeSegmentedSieve(int n)
        {

        }
    }
}
