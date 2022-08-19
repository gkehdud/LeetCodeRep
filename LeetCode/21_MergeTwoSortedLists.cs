using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _21_MergeTwoSortedLists
    {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val)
            {
                this.val = val;
            } 
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode(-1);
            ListNode temp = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    temp.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    temp.next = list2;
                    list2 = list2.next;
                }
                temp = temp.next;
            }
            if (list1 != null) temp.next = list1;
            if (list2 != null) temp.next = list2;

            return dummy.next;
        }
    }
}
