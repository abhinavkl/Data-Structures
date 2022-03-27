using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Code.Programs
{
    internal class GCDStrings
    {
        public static void Solution(int a,string b)
        {
            bool isInteger = Regex.IsMatch(b, @"^[\d]+$");
            Console.WriteLine(isInteger);
        }
    }
}
