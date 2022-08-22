// See https://aka.ms/new-console-template for more information
using LeetCode;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using static LeetCode.TreeNodeClass;

class Program 
{
    public static void Main(String[] args)
    {
        //_1_TwoSum.QnA();

        /* _3_LengthOfLongestSubstring
        String[] aa = new string[4] { "gin", "zen", "gig", "msg" };
        Console.WriteLine(UniqueMorseRepresentations(aa));
        Console.WriteLine(_3_LengthOfLongestSubstring.LengthOfLongestSubstring("abcabcbb"));
        */

        //Console.WriteLine(_69_Sqrtx.MySqrt(1));

        /*
        _21_MergeTwoSortedLists.ListNode l1 = new _21_MergeTwoSortedLists.ListNode(1);
        l1.next = new _21_MergeTwoSortedLists.ListNode(2);
        l1.next.next = new _21_MergeTwoSortedLists.ListNode(4);
        _21_MergeTwoSortedLists.ListNode l2 = new _21_MergeTwoSortedLists.ListNode(1);
        l2.next = new _21_MergeTwoSortedLists.ListNode(3);
        l2.next.next = new _21_MergeTwoSortedLists.ListNode(4);

        _21_MergeTwoSortedLists.ListNode mergedList = _21_MergeTwoSortedLists.MergeTwoLists(l1,l2);
        while (mergedList != null)
        {
            Console.WriteLine(mergedList.val);
            mergedList = mergedList.next;
        }
        */
        TreeNodeClass.TreeNode treeNode = TreeNodeClass.TreeNode.TreeNodeInitialized();
        var IORlist = new List<int>();
        var IOIlist = new List<int>();
        var IOMlist = new List<int>();
        var PRRlist = new List<int>();
        TreeNodeClass.TreeNode.Print("IOR", "InOrderTraversalRecursive", treeNode, IORlist);
        TreeNodeClass.TreeNode.Print("IOI", "InOrderTraversalIterative", treeNode, IOIlist);
        TreeNodeClass.TreeNode.Print("IOM", "InOrderTraversalMorris   ", treeNode, IOMlist);
        TreeNodeClass.TreeNode.Print("PRR", "PreOrderTraversalRecursive", treeNode, PRRlist);


    }


    
}