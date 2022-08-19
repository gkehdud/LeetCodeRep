using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.TreeNodeClass;

namespace LeetCode
{
    internal class TreeNodeClass
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            private static IList<int> res= new List<int>();
            public TreeNode(int x)
            {
                val = x;
            }
            public static TreeNode TreeNodeInitialized()
            {
                //                50
                //          17          72  
                //      12      23  54      76 
                //   9     14          67    
                

                TreeNode root = new TreeNode(50);
                root.left = new TreeNode(17);
                root.left.left = new TreeNode(12);
                root.left.right = new TreeNode(23);
                root.left.left.left = new TreeNode(9);
                root.left.left.right = new TreeNode(14);

                root.right = new TreeNode(72);
                root.right.left = new TreeNode(54);
                root.right.right = new TreeNode(76);
                root.right.left.right = new TreeNode(67);

                return root;
            }
            public static IList<int> InOrderTraversalRecursive(TreeNode root)
            {
                if (root is null) return res;

                if (root.left != null) InOrderTraversalRecursive(root.left);
                res.Add(root.val);
                if (root.right != null) InOrderTraversalRecursive(root.right);

                return res;

            }
            public static IList<int> InOrderTraversalIterative(TreeNode root)
            {
                //IList<int> res = new List<int>();
                //if (root is null) return res;
                //Stack<TreeNode> stack = new Stack<TreeNode>();

                //stack.Push(root);

                //while (stack.Any())
                //{
                //    var temp = stack.Pop();
                //    if (temp != null)
                //    {
                //        res.Add(root.val);
                //        stack.Push(root.right);
                //        stack.Push(root.left);
                //    }
                //}
                //return res;

                var list = new List<int>();

                if (root is null) return list;

                var stack = new Stack<TreeNode>();
                var node = root;
                while (node != null || stack.Any())
                {
                    while (node != null)
                    {
                        stack.Push(node);
                        node = node.left;
                    }

                    node = stack.Pop();
                    list.Add(node.val);
                    node = node.right;
                }
                return list;
            }
            public static void Print(String Type, String Name, TreeNode treenode, IList<int> list) {
                switch (Type)
                {
                    case "IOR":
                        list = TreeNodeClass.TreeNode.InOrderTraversalRecursive(treenode);
                        break;
                    case "IOI":
                        list = TreeNodeClass.TreeNode.InOrderTraversalIterative(treenode);
                        break;
                    case "PRR":
                        Console.Write("testsedgsgggggt");
                        break;
                    case "PRI":
                        break;
                    case "POR":
                        break;
                    case "POI":
                        break;
                    default:
                        break;
                }

                Console.Write(Name + " : [");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i]);
                    if (i != list.Count - 1) Console.Write(",");

                }
                Console.Write("]\n");
            }

            
        }
        
    }
}
