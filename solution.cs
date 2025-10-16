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
    public void isMirror(TreeNode r1, TreeNode r2, bool[] tf){
        if(r1 == null && r2 == null){
            return;
        }

        if(r1 == null && r2 != null){
            tf[0] = false;
            return;
        }

        if(r1 != null && r2 == null){
            tf[0] = false;
            return;
        }

        if(r1.val == r2.val){
            isMirror(r1.left, r2.right, tf);
            isMirror(r1.right, r2.left, tf);
        }
        else{
            tf[0] = false;
        }
    }

    public bool IsSymmetric(TreeNode root) {
        bool[] tf = {true};
        isMirror(root.left, root.right, tf);
        return(tf[0]);
    }
}
