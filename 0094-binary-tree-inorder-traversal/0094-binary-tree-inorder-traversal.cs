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
        if(root == null)
            return new List<int>();

        TreeNode curr = root;
        var ans = new List<int>();
        var treeNodes = new Stack<TreeNode>();

        while(curr != null || treeNodes.Count != 0){
            while(curr != null){
                treeNodes.Push(curr);
                curr = curr.left;
            }

            curr = treeNodes.Pop();
            ans.Add(curr.val);
            curr = curr.right;
        }

        return ans;
    }
}