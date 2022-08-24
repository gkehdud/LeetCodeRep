using System;
using System.Collections.Generic;
using System.Linq;
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
                    while (temp.next.next != null) temp = temp.next;

                    temp.next = null;
                    count--;
                    
                }
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
                    if (n > count) Console.WriteLine("LinkedSize : " + count + " Your input value : " + n + " , So We added your input value to end index.");
                    DeleteNodeToEnd();
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
            public void Start()
            {
                bool MenuSelected = false;
                bool waiting = false;
                String Type = "";
                Console.Write("$$$$$$$$$$$$$$  ListNode(Single Linked List) Start!  $$$$$$$$$$$$$$\n F1 : Add Node To Front       F2 : Add Node To End       F3 : Add Node To N\n" +
                    " F4 : Delete Node To Front    F5 : Delete Node To End    F6 : Delete Node To N");
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
                            default:
                                break;
                        }
                    }
                    else
                    {
                        
                        Console.Write("\n\n==========" + Type + "==========   Current ListNode : ");
                        PrintList();
                        string input;
                        Console.WriteLine();
                        Console.Write("Data : ");
                        input = Console.ReadLine();
                        String Position;
                        switch (Type)
                        {
                            case "AddNodeToFront":
                                AddNodeToFront(Convert.ToInt32(input));
                                break;
                            case "AddNodeToEnd":
                                AddNodeToEnd(Convert.ToInt32(input));
                                break;
                            case "AddNodeToN":
                                Console.Write("Position : ");
                                Position = Console.ReadLine();
                                AddNodeToN(Convert.ToInt32(input), Convert.ToInt32(Position));
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
                                DeleteNodeToN(Convert.ToInt32(Position));
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
                Console.Write("TESTSETEST");
                int n = 0;
                LinkedListNode runner = head;
                Console.Write("[");
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
