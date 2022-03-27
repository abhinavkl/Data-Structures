using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Code.Basic
{
    internal class BinaryOperations
    {
        public static long GetBinary(long n)
        {
            long pos = 1;
            long res = 0;
            while (n != 0)
            {
                res = res + (n & 1) * pos;
                pos = pos * 10;
                n=n >> 1;
            }
            return res;
        }

        public static long BinaryComplement(long n)
        {
            return (~n * -1);
        }

        public static long GetBinary(List<long> al)
        {
            long n = 0;
            for (int i = al.Count() - 1; i >= 0; i--)
            {
                n += (long)(al[i] * Math.Pow(10, i));
            }
            return n;
        }
        
        public static int GetIthBit(long n, int k)
        {
            return GetBinary(n & 1 << (k - 1)) == 0 ? 0 : 1;
        }

        public static long GetBitCount(long n)
        {
            var bitsCount = (long)Math.Floor((Math.Log(n) / Math.Log(2)));
            if ((n & n - 1) == 0)
            {
                bitsCount += 1;
            }
            return bitsCount;
        }

        public static long ClearIthBit(long n, int k)
        {
            var allBitCount = GetBitCount(n);
            if (k <= allBitCount)
            {
                return n & ((((1 << (int)(allBitCount - k)) - 1) << k) | (1 << k - 1) - 1);
            }
            else return n;
        }

        public static long SetIthBit(long n, long k)
        {
            return (1 << (int)k) | (int)n;
        }

        public static long UpdateIthBit(long n, int k, int b)
        {
            return b == 0 ? ClearIthBit(n, k) : SetIthBit(n, ClearIthBit(n, k));
        }

        public static long ClearItoJBits(long n, int i, long j)
        {
            var allBitCount = GetBitCount(n);
            return ((((1 << (int)(allBitCount - j)) - 1) << (int)(j)) | (1 << i - 1) - 1);
        }

        public static long ReplaceBits(long n, int k, long r)
        {
            var replaceWith = r << k - 1;
            var replacingBitCount = GetBitCount(replaceWith);
            return ClearItoJBits(n, k, replacingBitCount + k - 2) | replaceWith;
        }

        public static long CountNoOfOne(long n)
        {
            long cnt = 0;
            while (n > 0)
            {
                n &= (n - 1);
                cnt++;
            }
            return cnt;
        }


    }
}
