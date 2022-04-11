using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresPrograms.Extensions;

namespace DataStructuresPrograms.Code.Basic
{
    internal static class Greedy
    {
        public static void CoinsExchange(int cost)
        {
            int[] denom = new int[] { 1,2,5,10,20,50,100,200,500,2000};
            int counter = 0;
            Console.WriteLine(cost);
            while (cost != 0)
            {
                int nearestDenom = denom.GetNearestFloorNumber(cost);
                cost -= nearestDenom;
                counter++;
                Console.WriteLine(cost+" after denom :"+nearestDenom);
            }            
        }
    }
}
