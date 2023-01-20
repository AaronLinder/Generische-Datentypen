using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LinkedList
{
    public interface IMyList
    {
        void SwitchNodes(Node firstNode, Node secondNode);
        void SetSortStrategy(SortStrategy sortStrategy);
        Node GetFirst();

        Node GetLast();
        void Sort();
        void SortDesc();
    }

    public abstract class SortStrategy
    {
        public abstract void Sort(IMyList list);
        public abstract void SortDesc(IMyList list);
    }

    public class InsertionSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            var nextNode = list.GetFirst().next;

            while (nextNode != null)
            {
                for (var cur = list.GetFirst(); cur.next != null; cur = cur.next)
                {
                    if (cur == nextNode)
                        break;
                    if (cur.data < nextNode.data)
                        continue;
                    (cur.data, nextNode.data) = (nextNode.data, cur.data);
                }
                nextNode = nextNode.next;
            }
            Console.WriteLine("InsertionSorted list ");
        }

        public override void SortDesc(IMyList list)
        {
            throw new NotImplementedException();
        }
    }

    public class Quicksort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            sort(list.GetFirst(), list.GetLast());
        }

        public override void SortDesc(IMyList list)
        {
            throw new NotImplementedException();
        }

        Node paritionLast(Node start, Node end)
        {
            if (start == end || start == null || end == null)
                return start;

            Node pivot_prev = start;
            Node curr = start;
            int pivot = end.data;
            int temp;

            while (start != end)
            {
                if (start.data < pivot)
                {
                    pivot_prev = curr;
                    temp = curr.data;
                    curr.data = start.data;
                    start.data = temp;
                    curr = curr.next;
                }
                start = start.next;
            }


            temp = curr.data;
            curr.data = pivot;
            end.data = temp;

            return pivot_prev;
        }

        void sort(Node start, Node end)
        {
            if (start == null || start == end || start == end.next)
                return;

            Node pivot_prev = paritionLast(start, end);
            sort(start, pivot_prev);

            if (pivot_prev != null && pivot_prev == start)
                sort(pivot_prev.next, end);

            else if (pivot_prev != null
                     && pivot_prev.next != null)
                sort(pivot_prev.next.next, end);
        }
    }

    public class ReverseInsertionSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            var nextNode = list.GetFirst().next;

            while (nextNode != null)
            {
                for (var cur = list.GetFirst(); cur.next != null; cur = cur.next)
                {
                    if (cur == nextNode)
                        break;
                    if (cur.data > nextNode.data)
                        continue;
                    (cur.data, nextNode.data) = (nextNode.data, cur.data);
                }
                nextNode = nextNode.next;
            }
            Console.WriteLine("ReverseInsertionSorted list ");
        }

        public override void SortDesc(IMyList list)
        {
            throw new NotImplementedException();
        }
    }

    public class BubbleSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            var Node = list.GetFirst();

            while (Node != null)
            {
                for (var cur = list.GetFirst(); cur.next != null; cur = cur.next)
                {
                    if(cur.next == null)
                    {
                        continue;
                    }
                    if (cur.data > cur.next.data)
                    {
                        list.SwitchNodes(cur, cur.next);
                    }
                }
                Node = Node.next;
            }
            Console.WriteLine("BubbleSorted list ");
        }

        public override void SortDesc(IMyList list)
        {
            var Node = list.GetFirst();

            while (Node != null)
            {
                for (var cur = list.GetFirst(); cur.next != null; cur = cur.next)
                {
                    if (cur.next == null)
                    {
                        continue;
                    }
                    if (cur.data < cur.next.data)
                    {
                        list.SwitchNodes(cur, cur.next);
                    }
                }
                Node = Node.next;
            }
            Console.WriteLine("BubbleSorted list ");
        }
    }
}