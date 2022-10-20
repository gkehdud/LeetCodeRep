using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    //https://csharp.hotexamples.com/examples/-/ListNode/-/php-listnode-class-examples.html
    internal class ListNode
    {
        public class LinkedListNode
        {
            public int val;
            public LinkedListNode? next;

            public LinkedListNode(int x)
            {
                val = x;
                next = null;
            }
        }
        public class LinkedList
        {
            int count;
            LinkedListNode? head;

            public LinkedList()
            {
                head = null;
                count = 0;
            }

            public void AddNodeToFront(int data)
            {
                LinkedListNode newNode = new LinkedListNode(data);
                newNode.next = head;
                head = newNode;
                count++;
            }
            public void AddNodeToEnd(int data)
            {
                LinkedListNode newNode = new LinkedListNode(data);
                if (head == null) head = newNode;
                else
                {
                    LinkedListNode temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = newNode;
                }
                count++;
            }
            public void DeleteNodeToFront()
            {
                if (head is null)
                {
                    Console.WriteLine("ListNode is empty.");
                    return;
                }
                else
                {
                    LinkedListNode temp = head.next;
                    head = temp;
                    count--;
                }
            }
            public void DeleteNodeToEnd()
            {
                if (head is null)
                {
                    Console.WriteLine("ListNode is empty.");
                    return;
                }
                else
                {
                    LinkedListNode temp = head;
                    if (head.next == null)
                    {
                        head = null;
                    }
                    else
                    {
                        while (temp.next.next != null) temp = temp.next;
                    }

                    temp.next = null;
                    count--;
                    
                }
            }
            public void DeleteNodeByData(int data)
            {
                bool ValidData = false;
                if (head is null)
                {
                    Console.WriteLine("ListNode is empty.");
                    return;
                }
                else
                {
                    LinkedListNode temp = head;

                    while (head != null && head.val == data)
                    {
                        head = head.next;
                        count--;
                    }

                    while (temp != null && temp.next != null)
                    {
                        if (temp.next.val == data)
                        {
                            ValidData = true;
                            temp.next = temp.next?.next;
                            count--;
                        }
                        else
                        {
                            temp = temp.next;
                        }
                    }

                    /* !!!!!!!!!!!!!!Dummy!!!!!!!!!!!!!!!
                    LinkedListNode dummy = head;
                    LinkedListNode prev = dummy;
                    LinkedListNode curr = head;
                    LinkedListNode next;

                    while (curr != null)
                    {
                        next = curr.next;

                        if (curr.val == data)
                        {
                            prev.next = next;
                            count--;
                        }
                        else
                        {
                            prev = curr;
                        }
                        curr = next;
                    }
                    head = dummy.next;
                    */
                }
                //if (!ValidData)
                //{
                //    Console.WriteLine("There is no '" + data + "' in ListNode.");
                //}
            }
            public void DeleteNodeToN(int n)
            {
                if (n < 0)
                {
                    Console.WriteLine("Contraints : 0 <= n");
                    return;
                }
                if (n == 0)
                {
                    DeleteNodeToFront();
                    return;
                }
                if (n >= count)
                {
                    if (n > count) Console.WriteLine("LinkedSize : " + count + " Your input value : " + n + ".");
                    return;
                }

                if (head is null)
                {
                    Console.WriteLine("ListNode is empty.");
                    return;
                }
                else
                {
                    LinkedListNode temp = head;

                    for (int i = 0; i < n - 1; i++)
                    {
                        if (temp != null) temp = temp.next;
                    }

                    if (temp == null || temp.next == null)
                    {
                        Console.WriteLine("Your input index 'n' is out of size.");
                        return;
                    }
                    temp.next = temp.next.next;
                    count--;
                }

            }
            public void AddNodeToN(int data, int n)
            {
                int index = 0;
                LinkedListNode newNode = new LinkedListNode(data);

                if (n < 0)
                {
                    Console.WriteLine("Contraints : 0 <= n");
                    return;
                }
                if (n == 0)
                {
                    AddNodeToFront(data);
                    return;
                }
                if (n >= count)
                {
                    if (n > count) Console.WriteLine("LinkedSize : '" + count + "' Your input value : '" + n + "' , So We added your input value to end index.");
                    AddNodeToEnd(data);
                    return;
                }

                if (head == null)
                {
                    Console.WriteLine("ListNode is empty. There is no data in 'n' index.");
                    head = newNode;
                    return;
                }
                else
                {
                    LinkedListNode temp = head;

                    while (temp.next != null)
                    {
                        index++;
                        if (n == index)
                        {
                            newNode.next = temp.next;
                            temp.next = newNode;

                        }
                        temp = temp.next;
                    }
                    count++;
                }
                
            }
            public void ReverseIterative(LinkedListNode head)
            {
                LinkedListNode prev = null;
                LinkedListNode curr = head;
                LinkedListNode next = null;

                while (curr != null)
                {
                    next = curr.next;
                    curr.next = prev;
                    prev = curr;
                    curr = next;
                }

                this.head = prev;
            }
            public LinkedListNode ReverseRecursive(LinkedListNode head)
            {
                if (head is null || head.next is null) return head;

                LinkedListNode node = ReverseRecursive(head.next);
                head.next.next = head;
                head.next = null;

                this.head = node;
                return this.head;
            }
            public void ReverseStack(LinkedListNode head)
            {
                if (head is null || head.next is null) return;

                LinkedListNode res = new LinkedListNode(-1);
                LinkedListNode curr = res;
                Stack<int> stack = new Stack<int>();

                while (head != null)
                {
                    stack.Push(head.val);
                    head = head.next;
                }

                while (stack.Any())
                {
                    LinkedListNode node = new LinkedListNode(stack.Pop());
                    curr.next = node;
                    curr = curr.next;
                }

                this.head = res.next;
            }
            public void ReverseList(LinkedListNode head,string type)
            {
                switch (type)
                {
                    case "1": // Iterative
                        Console.WriteLine("\n==============================================================\n" +
                            "LinkedListNode prev = null;\nLinkedListNode curr = head;\nLinkedListNode next = null;" +
                            "\nwhile (curr != null){\n    next = curr.next;\n     curr.next = prev;\n     prev = curr;\n      curr = next;\n}\nthis.head = prev;" +
                            "\n==============================================================\n");
                        ReverseIterative(head);
                        break;
                    case "2": // Recursive
                        Console.WriteLine("\n==============================================================\n"
                            + "if (head is null || head.next is null) return head;\n"
                            + "\nLinkedListNode node = ReverseRecursive(head.next);\n"
                            + "head.next.next = head;\n"
                            + "head.next = null;\n"
                            + "\nthis.head = node;\n"
                            + "return this.head;\n"
                            + "\n==============================================================\n");

                        head = ReverseRecursive(head);
                        break;
                    case "3": // Stack
                        Console.WriteLine("\n==============================================================\n"
                            + "if (head is null || head.next is null) return;\n"
                            + "LinkedListNode res = new LinkedListNode(-1);\n"
                            + "LinkedListNode curr = res;\n"
                            + "Stack<int> stack = new Stack<int>();\n"
                            + "while (head != null)\n"
                            + "{\n"
                            + "     stack.Push(head.val);\n"
                            + "     head = head.next;\n"
                            + "}\n"
                            + "while (stack.Any())\n"
                            + "{\n"
                            + "     LinkedListNode node = new LinkedListNode(stack.Pop());\n"
                            + "     curr.next = node;\n"
                            + "     curr = curr.next;\n"
                            + "}\n"
                            + "\nthis.head = res.next;\n"
                            + "\n==============================================================\n");
                        ReverseStack(head);
                        break;
                    default:
                        Console.WriteLine("choose one among 1,2,3.");
                        break;
                }
            }
            public LinkedListNode SortList(LinkedListNode temp)
            {
                if (head == null || head.next == null)
                    return head;
                LinkedListNode slow = head;
                LinkedListNode fast = head;
                while (fast.next != null && fast.next.next != null)
                {
                    slow = slow.next;
                    fast = fast.next.next;
                }

                LinkedListNode mid = slow.next;
                slow.next = null;

                LinkedListNode left = SortList(head);
                LinkedListNode right = SortList(mid);
                LinkedListNode dummy = new LinkedListNode(0);
                LinkedListNode current = dummy;
                while (left != null && right != null)
                {
                    if (left.val < right.val)
                    {
                        current.next = left;
                        current = current.next;
                        left = left.next;
                    }
                    else
                    {
                        current.next = right;
                        current = current.next;
                        right = right.next;
                    }
                }

                if (left != null)
                    current.next = left;

                if (right != null)
                    current.next = right;

                return dummy.next;
            }
            //https://leetcode.com/problems/sort-list/discuss/455104/QuickSort-C
            public bool IsOnlyNumber(String Input)
            {
                int data;
                if (int.TryParse(Input, out data))
                    return true;
                else
                {
                    Console.WriteLine("Only Number available.");
                    return false;
                }
            }
            public void Start()
            {
                bool MenuSelected = false;
                bool waiting = false;
                String Type = "";
                Console.Write("$$$$$$$$$$$$$$  ListNode(Single Linked List) Start!  $$$$$$$$$$$$$$\n F1 : Add Node To Front       F2 : Add Node To End       F3 : Add Node To N\n" +
                    " F4 : Delete Node To Front    F5 : Delete Node To End    F6 : Delete Node To N     F7 : Delete Node By data    \n F8 : Sort     F9 : Reverse");
                do
                {
                    
                    if (!MenuSelected)
                    {
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.F1:
                                Type = "AddNodeToFront";
                                MenuSelected = true;
                                break;
                            case ConsoleKey.F2:
                                Type = "AddNodeToEnd";
                                MenuSelected = true;
                                break;
                            case ConsoleKey.F3:
                                Type = "AddNodeToN";
                                MenuSelected = true;
                                break;
                            case ConsoleKey.F4:
                                Type = "DeleteNodeToFront";
                                MenuSelected = true;
                                break;
                            case ConsoleKey.F5:
                                Type = "DeleteNodeToEnd";
                                MenuSelected = true;
                                break;
                            case ConsoleKey.F6:
                                Type = "DeleteNodeToN";
                                MenuSelected = true;
                                break;
                            case ConsoleKey.F7:
                                Type = "DeleteNodeByData";
                                MenuSelected = true;
                                break;
                            case ConsoleKey.F8:
                                Type = "SortListNode";
                                MenuSelected = true;
                                break;
                            case ConsoleKey.F9:
                                Type = "ReverseListNode";
                                MenuSelected = true;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        
                        Console.Write("\n\n==========" + Type + "==========   Current ListNode ");
                        PrintList();
                        string input;
                        int data;
                        Console.WriteLine();
                        String Position;
                        switch (Type)
                        {
                            case "AddNodeToFront":
                                Console.Write("Data : ");
                                input = Console.ReadLine();
                                if (IsOnlyNumber(input))   AddNodeToFront(Convert.ToInt32(input));
                                break;
                            case "AddNodeToEnd":
                                Console.Write("Data : ");
                                input = Console.ReadLine();
                                if (IsOnlyNumber(input))    AddNodeToEnd(Convert.ToInt32(input));
                                break;
                            case "AddNodeToN":
                                Console.Write("Data : ");
                                input = Console.ReadLine();
                                Console.Write("Position : ");
                                Position = Console.ReadLine();
                                if (IsOnlyNumber(input) && IsOnlyNumber(Position))  AddNodeToN(Convert.ToInt32(input), Convert.ToInt32(Position));
                                break;
                            case "DeleteNodeToFront":
                                DeleteNodeToFront();
                                break;
                            case "DeleteNodeToEnd":
                                DeleteNodeToEnd();
                                break;
                            case "DeleteNodeToN":
                                Console.Write("Position : ");
                                Position = Console.ReadLine();
                                if (IsOnlyNumber(Position))    DeleteNodeToN(Convert.ToInt32(Position));
                                break;
                            case "DeleteNodeByData":
                                Console.Write("Data : ");
                                Position = Console.ReadLine();
                                if (IsOnlyNumber(Position))     DeleteNodeByData(Convert.ToInt32(Position));
                                break;
                            case "SortListNode":
                                //head = SortList(head);
                                break;
                            case "ReverseListNode":
                                Console.Write("choose one 1:Iterative   2:Recursive   3:Stack \nType: ");
                                String type = Console.ReadLine();
                                ReverseList(head,type);
                                break;
                            default:
                                break;
                        }
                        MenuSelected = false;
                        PrintList();

                        //if (!waiting)
                        //{
                        //    waiting = true;
                        //}
                        //if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                        //{
                        //    MenuSelected = false;
                        //    waiting = false;
                        //    Console.WriteLine("--------------CANCEL--------------");
                        //}

                    }
                    
                } while (true);  
            }
            public void PrintList()
            {
                int n = 0;
                LinkedListNode runner = head;
                Console.Write("=> [");
                while (runner != null)
                {
                    Console.Write(runner.val);
                    n++;
                    if(count != n)  Console.Write(",");
                    runner = runner.next;
                    
                }
                Console.Write("]");
            }
        }
    }
}
