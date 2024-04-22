// See https://aka.ms/new-console-template for more information

using ConstructStringFromBinaryTree;

Console.WriteLine("Hello, World!");


public class Solution {
    public string Tree2str(TreeNode root) {
        if (root is null) return "()";
        return Node2str(root);
    }
    
    public string Node2str(TreeNode node){
        if (node is not null) {
            string result = node.val.ToString();
            if (node.left is not null || node.right is not null){
                result += "(";
                result += Node2str(node.left);
                result += ")";
                if (node.right is not null){
                    result += "(";
                    result += Node2str(node.right);
                    result += ")";
                }
            }
            return result;
        }
        return String.Empty;
    }
    
}