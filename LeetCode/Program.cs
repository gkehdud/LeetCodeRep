// See https://aka.ms/new-console-template for more information
using LeetCode;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Transactions;
using static LeetCode.TreeNodeClass;

class Program
{
    public static void Main(String[] args)
    {

        _200_NumberOfIslands _200numberOfIslands = new _200_NumberOfIslands();
        _191_Numberof1Bits _191numberof1Bits = new _191_Numberof1Bits();
        _202_HappyNumber _202happyNumber = new _202_HappyNumber();
        _869_ReorderedPower _869_ReorderedPower = new _869_ReorderedPower();
        _838_PushDominoes _838_PushDominoes = new _838_PushDominoes();
        /*
        _1_TwoSum.QnA();
        */


        /* _3_LengthOfLongestSubstring
        String[] aa = new string[4] { "gin", "zen", "gig", "msg" };
        Console.WriteLine(UniqueMorseRepresentations(aa));
        Console.WriteLine(_3_LengthOfLongestSubstring.LengthOfLongestSubstring("abcabcbb"));
        */


        /*
        Console.WriteLine(_69_Sqrtx.MySqrt(1));
        */


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

        //Console.WriteLine(Math.Log2(15));

        //int n = 3;
        //long result = 0;
        //long m = 2;
        //long mod = 1000000007;

        //for (int i = 1; i <= n; i++)
        //{
        //    if (i == m)
        //    {
        //        m *= 2;
        //    }
        //    result = (result * m + i);
        //}

        //Console.WriteLine(result);

        //TreeNodeClass.TreeNode treeNode;
        //treeNode = TreeNodeClass.TreeNode.TreeNodeInitialized();
        //treeNode.Print("IOR", "InOrderTraversalRecursive", treeNode, new List<int>());
        //treeNode.Print("IOI", "InOrderTraversalIterative", treeNode, new List<int>());
        //treeNode.Print("IOM", "InOrderTraversalMorris   ", treeNode, new List<int>());
        //treeNode.AverageOfLevels(treeNode);
        //Console.WriteLine(treeNode.GoodNodes(treeNode));
        //TreeNodeClass.TreeNode.Print("PRR", "PreOrderTraversalRecursive", treeNode, PRRlist);



        /*
        int n = 2014;
        HashSet<string> hset = new HashSet<string>();
        for (int i = 1; i < 1000000000; i *= 2)
        {
            hset.Add(Ordered(i));
            Console.WriteLine(Ordered(i));
        }
        Console.WriteLine(Ordered(n));
        */



        //ListNode.LinkedList linkedList = new ListNode.LinkedList();
        //Thread threadobj = new Thread(linkedList.Start);
        //threadobj.Start();





        //_191numberof1Bits.Start();
        //_200numberOfIslands.Start();
        //_202happyNumber.Start();
        //_869_ReorderedPower.Start();
        _838_PushDominoes.start();

    }

    //public static string Ordered(int num)
    //{
    //    return new string(num.ToString().ToCharArray().OrderBy(c => c).ToArray());
    //}
}