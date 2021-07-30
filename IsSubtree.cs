using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class IsSubtree
    {
        public bool isSubtree(TreeNode root, TreeNode subRoot)
        {

            if (root == null && subRoot == null) return true;
            if (root == null || subRoot == null) return false;

            // Case 1: Subtree begins at this level
            if (root.val == subRoot.val)
            {
                if (isSameTree(root.left, subRoot.left) && isSameTree(root.right, subRoot.right)) return true;
            }

            // Case 2: Subtree begins at lower level
            return isSubtree(root.left, subRoot) || isSubtree(root.right, subRoot);

        }

        private bool isSameTree(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return true;
            if (t1 == null || t2 == null) return false;
            if (t1.val != t2.val) return false;

            return isSameTree(t1.left, t2.left) && isSameTree(t1.right, t2.right);
        }
    }
}
