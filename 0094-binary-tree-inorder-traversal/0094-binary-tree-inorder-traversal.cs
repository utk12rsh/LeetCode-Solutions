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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> ans = new List<int>();

        InorderTraversal(root, ans);
        return ans;
    }

    public void InorderTraversal(TreeNode curr, List<int> ans){
        if(curr == null)
            return;

        InorderTraversal(curr.left, ans);
        ans.Add(curr.val);
        InorderTraversal(curr.right, ans);
    }
}