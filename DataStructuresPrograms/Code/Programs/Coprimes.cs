using DataStructuresPrograms.Code.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Code.Programs
{
    internal class Coprimes
    {
        public static void Soultion(int num)
        {
            int sqrt = (int)Math.Sqrt(num);
            int[] sieve = new int[num+1];
            List<int> primes = new List<int>();
            for(int i = 2; i <= num; i++)
            {
                if (sieve[i] == 0)
                    primes.Add(i);
                for(int j = i * i; j <= num; j += i)
                {
                    sieve[j] = 1;
                }
            }

            int counter = 0;
            for(int i = 1; i < primes.Count; i++)
            {
                if (primes[i] - primes[i - 1] == 2)
                    counter++;
            }
            PrintObject.Print(primes);
        }
    }
}
