using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public class SingleLinkedList
    {
        Node head;
        int count;
        public SingleLinkedList()
        {
            head = null;
        }

        public override string ToString()
        {

            Node current = head;
            String result = "";
            while (current != null)
            {
                result += current.data + "\n";
                current = current.next;
            }

            return result;
        }
        public void insert_front(int newElement)
        {
            Node newNode = new Node();
            newNode.data = newElement;
            newNode.next = head;
            head = newNode;
            count++;
        }
        public void InsertAfter(Node previousNode, int newData)
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode == previousNode)
                {
                    Node previousNextNode = currentNode.next;
                    currentNode.next = new Node(newData);
                    currentNode.next.next = previousNextNode;
                    count++;
                }
                if (currentNode.next == null)
                {
                    return;
                }
                currentNode = currentNode.next;
            }
            count++;
        }

        public void insert_AtTheEnd(int newElement)
        {
            Node newNode = new Node();
            newNode.data = newElement;
            newNode.next = null;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = new Node();
                temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = newNode;
            }
            count++;
        }

        public Node? GetNode(int data)
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.data.Equals(data))
                {
                    return currentNode;
                }

                if (currentNode.next == null)
                {
                    return null;
                }
                currentNode = currentNode.next;
            }
            return null;
        }

        public void DeleteFirst()
        {
            count--;
            head = head.next;
        }

        public bool DeleteNode(Node node)
        {
            Node currentNode = head;
            Node previousNode = head;
            while (currentNode != null)
            {
                if (currentNode == node)
                {
                    if (currentNode == head)
                    {
                        DeleteFirst();
                    }
                    else
                    {
                        previousNode.next = currentNode.next;
                    }
                    count--;
                    return true;
                }

                if (currentNode.next == null)
                {
                    return false;
                }
                previousNode = currentNode;
                currentNode = currentNode.next;
            }

            return false;
        }

        public void delete_last()
        {
            if (this.head != null)
            {
                if (this.head.next == null)
                {
                    this.head = null;
                }
                else
                {
                    Node temp = new Node();
                    temp = this.head;
                    while (temp.next.next != null)
                        temp = temp.next;
                    Node lastNode = temp.next;
                    temp.next = null;
                    lastNode = null;
                }
            }
            count--;
        }


        public int size()
        {
            return count;
        }

        public void PrintList()
        {
            Node temp = new Node();
            temp = this.head;
            if (temp != null)
            {
                Console.Write("The list contains: ");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }
        }

        public void SwitchNodes(Node firstNode, Node secondNode)
        {
            var List = head;
            while (List != null)
            {
                if (firstNode.data == List.data)
                {
                    List.data = secondNode.data;
                }
                else if (secondNode.data == List.data)
                {
                    List.data = firstNode.data;
                }
                List = List.next;
            }
        }
    }
}

