using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Code.Basic
{
    internal class BinarySearch
    {
        static int LowerBoundIndex(int[] arr,int k)
        {
            int pos = 0;
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (arr[mid] == k)
                {
                    pos = mid;
                    end = mid - 1;
                }
                else if (arr[mid] > k)
                {
                    end = mid - 1;
                }
                else start = mid + 1;
            }
            
            return pos;
        }
        static int UpperBoundIndex(int[] arr, int k)
        {
            int pos = 0;
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (arr[mid] == k)
                {
                    pos = mid;
                    start = mid+1 ;
                }
                else if (arr[mid] > k)
                {
                    end = mid - 1;
                }
                else start = mid + 1;
            }

            return pos;
        }
        public static int FindFrequency(int[] arr,int k)
        {
            int lowerBound = 0;
            int upperBound = 0;
            lowerBound=LowerBoundIndex(arr,k);
            upperBound = UpperBoundIndex(arr,k);
            Console.WriteLine(upperBound-lowerBound+1);
            return upperBound-lowerBound+1;
        }
        static bool CanPlaceBirds(int birds,int[] nests,int sep)
        {
            int birdsPlaced = 1;
            int lastBirdLocation = nests[0];
            for(int i = 1; i < nests.Length - 1; i++)
            {
                int curLocation = nests[i];
                if (curLocation - lastBirdLocation >= sep)
                {
                    birdsPlaced++;
                    lastBirdLocation = curLocation;
                    if (birdsPlaced == birds)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static int MinimumDistanceAngryBirds(int[] nests,int birds)
        {
            int minDist = 0;
            int start = 0;
            int end = nests[nests.Length-1] - nests[0];
            while (start <= end)
            {
                int mid = (start + end) / 2;
                bool canPlace = CanPlaceBirds(birds,nests,mid);
                if (canPlace)
                {
                    minDist = mid;
                    start = mid + 1;
                }
                else end = mid - 1;
            }
            Console.WriteLine(minDist);
            return minDist;
        }


        static bool canTakeCoins(int[] coins,int sep,int partitions)
        {
            int counter = 0;
            int curSum = 0;
            for(int i = 0; i < coins.Length; i++)
            {
                curSum += curSum + coins[i];
                if (curSum >= sep)
                {
                    curSum = 0;
                    counter++;
                }
                if (counter >= partitions)
                {
                    break;
                }
            }
            if (counter == partitions)
            {
                return true;
            }
            else return false;
        }

        public static int GameOfGreed(int[] coins,int partitions)
        {
            int maxOptimal = 0;
            int start = 0;
            int end = coins.Sum();
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (canTakeCoins(coins, mid, partitions))
                {
                    maxOptimal = mid;
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return maxOptimal;
        }

        public static bool IsPerfectSquare(int number)
        {
            int start = 1; int end = number;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                int curSquare = mid * mid;
                if ( curSquare == number)
                    return true;
                if (curSquare < number)
                    start = mid + 1;
                else end = mid - 1;
            }
            return false;
        }



        public static int GetMinimumAttempts(int x,int y, int p,int q)
        {
            
            return 0;
        } 
    }
}
