using DataStructuresPrograms.Code.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresPrograms.Code.Basic;

namespace DataStructuresPrograms.Code.Algo
{
    internal static class Combinations
    {
        public static int counter = 0;
        public static int NcR(int n,int r)
        {
            if(n<r) return 1;
            return MathOperations.Factorial(n) / (MathOperations.Factorial(n - r) * MathOperations.Factorial(r)); 
        }

        public static List<int> Generate(int n,int select,int selected=0,int target=-1, int selectedCount = 0,List<int> arr=null)
        {
            if (target == -1) target = select;
            if(arr==null) arr=new List<int>();
            if (n < select || n<0 || select<0 || target-selectedCount > select) {
                return arr;
            }
            else if (selectedCount==target)
            {
                arr.Add(selected);
                return arr;
            }
            else
            {
                Generate(n - 1, select - 1, selected | 1 << (n-1),target,selectedCount+1,arr); //selected currently
                Generate(n - 1, select, selected,target,selectedCount,arr); //not selected currently
                return arr;
            }
        }
    }
}
