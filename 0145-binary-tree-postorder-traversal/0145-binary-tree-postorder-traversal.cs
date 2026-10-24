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
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> ans = new List<int>();

        PostorderTraversal(root, ans);
        return ans;
    }

    public void PostorderTraversal(TreeNode curr, List<int> ans){
        if(curr == null)
            return;

        PostorderTraversal(curr.left, ans);
        PostorderTraversal(curr.right, ans);
        ans.Add(curr.val);
    }
}