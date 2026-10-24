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
        if(root == null)
            return new List<int>();
        
        var ans = new List<int>();
        var treeNodes = new Stack<TreeNode>();

        treeNodes.Push(root);

        while(treeNodes.Count != 0){
            TreeNode curr = treeNodes.Pop();
            ans.Add(curr.val);
            if(curr.right != null)
                treeNodes.Push(curr.right);
            if(curr.left != null)
                treeNodes.Push(curr.left);
        }
        return ans;
    }
}