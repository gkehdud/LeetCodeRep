using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static LeetCode.ListNode;
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
            private static IList<int> PRres = new List<int>();
            private static int level = 0;
            private static string tree = "";

            int goodNodeCount = 0;
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

                

                //                3
                //          3          null  
                //      4      2  

                //TreeNode root = new TreeNode(3);
                //root.left = new TreeNode(3);
                //root.left.left = new TreeNode(4);
                //root.left.right = new TreeNode(2);

                //root.right = new TreeNode(1);

                Console.Write("[");
                level = MaxDepth(root);
                Console.Write(tree.Remove(tree.Length -1));
                Console.Write("]\nLevel : ");
                Console.WriteLine(level);

                
                return root;
            }
            public static int MaxDepth(TreeNode root)
            {
                if (root is null) return 0;

                if (root != null) tree += root.val+",";
                int left = MaxDepth(root.left);
                int right = MaxDepth(root.right);

                return Math.Max(left,right)+1;
            }
            public IList<double> AverageOfLevels(TreeNode root)
            {
                //IList<double> res = new List<double>();
                //if (root is null) return res;

                //Queue<TreeNode> q = new Queue<TreeNode>();

                //q.Enqueue(root);

                //while (q.Any())
                //{
                //    int count = q.Count;
                //    double sum = 0;

                //    for (int i = 0; i < count; i++)
                //    {
                //        TreeNode node = q.Dequeue();
                //        sum += node.val;

                //        if (root.left != null) q.Enqueue(root.left);
                //        if (root.right != null) q.Enqueue(root.right);
                //    }
                //    res.Add(sum/count);
                //}

                IList<double> res = new List<double>();
                var levels = new List<List<int>>();
                if (root is null) return res;

                DFSGetData(root, levels, 0);

                foreach (var level in levels)
                {
                    res.Add(level.Average());
                }

                void DFSGetData(TreeNode root, List<List<int>> list, int level) {
                    
                    if (root is null) return;
                    if (list.Count <= level)
                    {
                        list.Add(new List<int>());
                    }
                    list[level].Add(root.val);

                    DFSGetData(root.left, list, level + 1);
                    DFSGetData(root.right, list, level + 1);
                }


                Console.Write("Average of levels : [");
                for (int i = 0; i < res.Count; i++)
                {
                    Console.Write(res[i]);
                    if (i != res.Count - 1) Console.Write(",");

                }
                Console.Write("]\n");
                return res;
            }
            public IList<int> InOrderTraversalRecursive(TreeNode root)
            {
                if (root is null) return res;

                if (root.left != null) InOrderTraversalRecursive(root.left);
                res.Add(root.val);
                if (root.right != null) InOrderTraversalRecursive(root.right);

                return res;

            }
            public IList<int> InOrderTraversalIterative(TreeNode root)
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
            public IList<int> InOrderTraversalMorris(TreeNode root)
            {
                var list = new List<int>();
                if (root is null) return list;


                TreeNode curr, pre;
                curr = root;
                while (curr != null)
                {
                    if (curr.left == null)
                    {
                        list.Add(curr.val);
                        curr = curr.right;
                    }
                    else
                    {
                        pre = curr.left;
                        while (pre.right != null && pre.right != curr)
                        {
                            pre = pre.right;
                        }
                        if (pre.right == null)
                        {
                            pre.right = curr;
                            curr = curr.left;
                        }
                        else
                        {
                            list.Add(curr.val);
                            curr = curr.right;
                        }
                    }
                }
                return list;
            }
            public IList<int> PreOrderTraversalRecursive(TreeNode root)
            {
                if (root is null) return PRres;

                PRres.Add(root.val);
                if (root.left != null) PreOrderTraversalRecursive(root.left);
                if (root.right != null) PreOrderTraversalRecursive(root.right);

                return PRres;

            }
            public int GoodNodes(TreeNode root)
            {
                /*
                 * Given a binary tree root, a node X in the tree is named good 
                 * if in the path from root to X there are no nodes with a value greater than X.
                 * Return the number of good nodes in the binary tree.
                 */
                if (root is null) return 0;

                GoodNodesDFS(root, root.val);

                return goodNodeCount;
            }
            public void GoodNodesDFS(TreeNode root, int va)
            {
                if (root is null) return;
                if (val <= root.val) goodNodeCount++;

                GoodNodesDFS(root.left, Math.Max(root.val, val));
                GoodNodesDFS(root.right, Math.Max(root.val, val));
            }
            public void Print(String Type, String Name, TreeNode treenode, IList<int> list) {
                switch (Type)
                {
                    case "IOR":
                        list = InOrderTraversalRecursive(treenode);
                        break;
                    case "IOI":
                        list = InOrderTraversalIterative(treenode);
                        break;
                    case "IOM":
                        list = InOrderTraversalMorris(treenode);
                        break;
                    case "PRR":
                        list = PreOrderTraversalRecursive(treenode);
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
