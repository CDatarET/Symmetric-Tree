/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    public void isMirror(TreeNode r1, TreeNode r2, boolean[] tf){
        if(r1 == null && r2 == null){
            return;
        }

        if(r1 == null || r2 == null){
            tf[0] = false;
            return;
        }

        if(r1.val != r2.val){
            tf[0] = false;
            return;
        }

        isMirror(r1.left, r2.right, tf);
        isMirror(r1.right, r2.left, tf);
    }

    public boolean isSymmetric(TreeNode root) {
        boolean[] tf = {true};
        isMirror(root.left, root.right, tf);
        return(tf[0]);
    }
}
