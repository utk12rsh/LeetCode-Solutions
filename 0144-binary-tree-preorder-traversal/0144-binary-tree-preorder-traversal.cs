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
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> ans = new List<int>();

        PreorderTraversal(root, ans);   
        return ans;
    }

    public void PreorderTraversal(TreeNode curr, List<int> ans){
        if(curr == null)
            return;

        ans.Add(curr.val);
        PreorderTraversal(curr.left, ans);
        PreorderTraversal(curr.right, ans);
    }
}