using DataStructuresPrograms.Code.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Code.Programs
{
    internal class AliceAndCandies
    {
        public static void Solution(int num)
        {
            int[] factorisation = new int[num + 1];
            int sqrt = (int)Math.Sqrt(num);
            for (int i = 2; i <= sqrt; i++)
            {
                if (factorisation[i] == 0)
                    factorisation[i] = i;
                for (int j = i * i; j <= num; j += i)
                {
                    if (factorisation[j] == 0)
                        factorisation[j] = i;
                }
            }
            int numOfSelections = 0;
            while (num != 1)
            {
                if (factorisation[num] != 2)
                {
                    numOfSelections++;
                }
                num = num / factorisation[num];
            }
            Console.WriteLine(numOfSelections);
        }

        /*public static void Solution(int num)
        {
            int i = 3;
            int counter = 0;
            while (num != 1)
            {
                if (num % i == 0)
                {
                    do
                    {
                        counter++;
                        num = num / i;
                    }
                    while (num%i==0);
                }
                i += 2;
            }
            Console.WriteLine(counter);
        }
*/

    }
}
