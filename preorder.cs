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
        IList<int> res = new List<int>();
        void pro(TreeNode r){
            if(r == null){
                return;
            }
            res.Add(r.val);
            pro(r.left);
            pro(r.right);
        }
        pro(root);
        return res;
    }
}
