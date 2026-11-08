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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var ans = new List<IList<int>>();

        if(root == null)
            return ans;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0){
            int currLevelCount = queue.Count;
            int processedNodeCount = 0;
            var currLevel = new List<int>();

            while(processedNodeCount < currLevelCount){
                var curr = queue.Dequeue();
                currLevel.Add(curr.val);
                if(curr.left != null)
                    queue.Enqueue(curr.left);
                if(curr.right != null)
                    queue.Enqueue(curr.right);
                processedNodeCount++;
            }
            ans.Add(currLevel);
        }

        return ans;
    }
}