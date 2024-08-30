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
        IList<int> res = new List<int>();
        void ino(TreeNode r){
            if(r == null){
                return;
            }
            pot(r.left);
            res.Add(r.val);
            pot(r.right);
        }
        ino(root);
        return res;
    }
}
