using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlistuc
{
    class LinkedList
    {
        public Node head;

        internal int deletePerticulatElement(int v)
        {
            throw new NotImplementedException();
        }

        //  public void Add(int data)
        //{
        //   Node node = new Node(data);
        //         if (this.head == null)
        //          this.head = node;
        //      else
        //      {
        //           Node temp = head;
        //           while (temp.next != null)
        //           {
        //               temp = temp.next;
        //           }
        //           temp.next = node;
        //       }
        //         Console.WriteLine("{0} inserted into the linked list",node.data);
        //  }

        //     public void Append(int data)
        //    {
        //        Node node = new Node(data);
        //    Node temp = head;
        //         while (temp.next != null)
        //         {
        //             temp = temp.next;
        //         }
        //       temp.next = node;
        //         Console.WriteLine(node.data + " " + "Appended into Linked List ");

        //     }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Empty Linked list");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal Node DeleteFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }

        public Node DeleteLastNode()
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                return null;
            }
            if (this.head.next == null)
            {
                this.head = null;
                return null;
            }
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return newNode;
        }
        public bool Search(int input)
        {
            bool flag = false;
            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == input)
                    {
                        Console.WriteLine("The element is present");
                        flag = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (!flag)
                    Console.WriteLine("The Element is Absent");
            }
            return flag;

        }

        internal void AddAfterAtPerticulatPosition(int data)
        {
            Node newnode = new Node(40);
            Node temp = head;

            while (temp.next != null)
            {
                if (temp.data == data)
                {
                    newnode.next = temp.next;
                    temp.next = newnode;
                }
                temp = temp.next;
            }
            Console.WriteLine("Given LinkedList = " + head.data);
        }
    }
}
