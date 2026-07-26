/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
 
public class Solution {
    public List<List<int>> LevelOrder(TreeNode root) {
        if (root == null)
        {
            return [];
        }

        if (root.left == null && root.right == null)
        {
            return [[root.val]];
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        var result = new List<List<int>>();
        result.Add([root.val]);

        while (queue.Count > 0)
        {
            var levelSize = queue.Count;

            for (int i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            if (queue.Count > 0)
            {
                var levelItems = queue.Select(e => e.val).ToList();
                result.Add(levelItems);
            }
        }

        return result;
    }
}
