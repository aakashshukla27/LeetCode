public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
            IList<IList<int>> result = new List<IList<int>>();
            List<int> currentResult = new List<int> ();
            DFS(root, targetSum, result, currentResult);
            return result;
    }
    public void DFS(TreeNode root, int targetSum, 
            IList<IList<int>> resultSet, List<int> current)
        {
            if (root == null) return;
            current.Add(root.val);

            if(root.left == null && root.right == null )
            {
                if(root.val - targetSum == 0)
                {
                     resultSet.Add(new List<int>(current));
                }
                return;                
            }
            

            if (root.left != null)
            {
                DFS(root.left, targetSum - root.val, resultSet, current);
                current.RemoveAt(current.Count - 1);
            }

            if(root.right != null)
            {
                DFS(root.right, targetSum - root.val, resultSet, current);
                current.RemoveAt(current.Count - 1);
            }
        }
