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
        var ans = new List<int>();

        if(root == null)
            return ans;
        
        var s1 = new Stack<TreeNode>();
        TreeNode curr = root;
        TreeNode lastVisitedNode = null;

        while(s1.Count > 0 || curr != null){
            while(curr != null){
                s1.Push(curr);
                curr = curr.left;
            }

            TreeNode peek = s1.Peek();
            if(peek.right != null && lastVisitedNode != peek.right){
                curr = peek.right;
            }
            else{
                ans.Add(peek.val);
                lastVisitedNode = s1.Pop();
            }
        }

        return ans;
    }
}