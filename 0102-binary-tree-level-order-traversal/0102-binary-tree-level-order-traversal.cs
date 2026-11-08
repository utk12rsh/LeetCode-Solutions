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

        var q1 = new Queue<TreeNode>();
        var q2 = new Queue<TreeNode>();

        q1.Enqueue(root);

        while(q1.Count > 0){
            var currLevel = new List<int>();

            while(q1.Count > 0){
                var curr = q1.Dequeue();
                currLevel.Add(curr.val);
                if(curr.left != null)
                    q2.Enqueue(curr.left);
                if(curr.right != null)
                    q2.Enqueue(curr.right);
            }

            ans.Add(currLevel);
            
            var temp = q1;
            q1 = q2;
            q2 = temp;
        }
        return ans;
    }
}