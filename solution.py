# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def isMirror(self, r1, r2, tf):
        if not r1 and not r2:
            return
        
        if not r1 or not r2:
            tf[0] = False
            return
        
        if r1.val != r2.val:
            tf[0] = False
            return

        self.isMirror(r1.left, r2.right, tf)
        self.isMirror(r1.right, r2.left, tf)

    def isSymmetric(self, root):
        tf = [True]
        self.isMirror(root.left, root.right, tf)
        return tf[0]
