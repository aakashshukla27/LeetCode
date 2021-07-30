using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class CherryPickup
    {
        private int cheryyCount = 0;
        public int CherryPickupProblem(int[][] grid)
        {
            int N = grid.Length;
            int M = N - 1;
            int[][] dp = new int[N][];
            dp[0] = grid[0];

            for (int n = 0; n < M; n++)
            {
                for (int i = N-1; i >= 0; i--)
                {
                    for (int p = N-1; p >= 0; p--)
                    {
                        int j = n - i;
                        int q = n - p;
                        if(j < 0 || j >= N-1 || q < 0 || q >= N || grid[i][i] < 0 || grid[p][q] < 0)
                        {
                            dp[i][p] = -1;
                            continue;
                        }
                        if (i > 0) dp[i][p] = Math.Max(dp[i][p], dp[i - 1][p]);
                        if (p > 0) dp[i][p] = Math.Max(dp[i][p], dp[i][p - 1]);
                        if (i > 0 && p > 0) dp[i][p] = Math.Max(dp[i][p], dp[i - 1][p - 1]);

                        if (dp[i][p] >= 0) dp[i][p] += grid[i][j] + (i != p ? grid[p][q] : 0);
                    }
                    
                }
            }

            return Math.Max(dp[N - 1][N - 1], 0);
        }

        private List<int> MoveDown(int[][] grid, int i, int j)
        {
            int n = grid[0].Length;

            while (i < n && j < n)
            {
                if (i < n)
                {

                }
            }

            return new List<int>();
        }

        private List<int> MoveUp(int[][] grid, int i, int j)
        {
            return new List<int>();
        }

    }
}
