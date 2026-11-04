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
        if(root == null)
            return new List<int>();
        
        List<int> ans = new List<int>();
        var s1 = new Stack<TreeNode>();
        var s2 = new Stack<TreeNode>();
        s1.Push(root);
        
        TreeNode curr = null;
        while(s1.Count > 0){
            curr = s1.Pop();
            s2.Push(curr);
            if(curr.left != null)
                s1.Push(curr.left);
            if(curr.right != null)
                s1.Push(curr.right);
        }

        while(s2.Count > 0){
            curr = s2.Pop();
            ans.Add(curr.val);
        }

        return ans;
    }
}