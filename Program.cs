using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 4, 3, 1, 3, 2 };
            jaggedArray[1] = new int[] { 3, 2, 1, 3, 2, 4 };
            jaggedArray[2] = new int[] { 2, 3, 3, 2, 3, 1 };
            TrappingRainWater2 tp = new TrappingRainWater2();
            tp.TrapRainWater(jaggedArray);
        }
    }
}
