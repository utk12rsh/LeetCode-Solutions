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
        LevelOrder(root, 0, ans);
        return ans;
    }

    public void LevelOrder(TreeNode curr, int level, List<IList<int>> ans){
        if(curr == null)
            return;
        
        if(ans.Count <= level)
            ans.Add(new List<int>());

        ans[level].Add(curr.val);

        LevelOrder(curr.left, level + 1, ans);
        LevelOrder(curr.right, level + 1, ans);
    }
}