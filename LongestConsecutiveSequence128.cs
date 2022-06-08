public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length < 2) return nums.Length;
        var uf = new UnionFind(nums.Length);
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
            else
            {
                continue;
            }
            if (dict.ContainsKey(nums[i] - 1))
            {
                uf.Union(i, dict[nums[i] - 1]);
            }
            if(dict.ContainsKey(nums[i] + 1))
            {
                uf.Union(i, dict[nums[i] + 1]);
            }
        }

        return uf.maxSize;
    }
    
    public class UnionFind
    {
        private int[] parent;
        private int[] size;
        public int maxSize {get; set;} = 1;

        public UnionFind(int n)
        {
            parent = Enumerable.Range(0, n).ToArray();
            size = Enumerable.Repeat(1, n).ToArray();
        }

        public int Find(int p)
        {
            while (p != parent[p])
            {
                parent[p] = parent[parent[p]];
                p = parent[p];
            }
            return p;
        }

        public void Union(int p, int q)
        {
            int pRoot = Find(p);
            int qRoot = Find(q);

            if (pRoot == qRoot) return;
            if (size[pRoot] < size[qRoot])
            {
                parent[pRoot] = qRoot;
                size[qRoot] += size[pRoot];
                maxSize = Math.Max(maxSize, size[qRoot]);
            }
            else
            {
                parent[qRoot] = pRoot;
                size[pRoot] += size[qRoot];
                maxSize = Math.Max(maxSize, size[pRoot]);
            }
                
        }

    }
}
