using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MaxProfit
    {
        public int MaxProfitSolution(int[] prices)
        {
            int max = 0;
            int min = int.MaxValue;

            for(int i=0;i< prices.Length; i++)
            {
                if(prices[i] < min)
                {
                    min = prices[i];
                }
                else
                {
                    max = Math.Max(max, prices[i] - min);
                }
            }
            return max;
        }
    }
}
