using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Extensions
{
    internal static class StringExt
    {
        public static string Swap(this String str,int i,int j)
        {
            if(i==j)
                return str;
            else
            {
                char[] arr = str.ToCharArray();
                char temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                return new string(arr);
            }
        }
    }
}
