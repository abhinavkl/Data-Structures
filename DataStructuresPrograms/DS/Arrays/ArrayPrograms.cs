﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPrograms.DS.Arrays
{
    internal class ArrayPrograms
    {
        public static void Run()
        {
            int[] arr = new int[] { 1,2,3,4,5,6,7 };
            Rotation.Left(arr,2);
        }
    }
}