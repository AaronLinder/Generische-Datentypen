using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public class MyStacks
    {
        private SingleLinkedList internalList = new SingleLinkedList();

        public Node Push(int argValue)
        {
            var nodeToAdd = new Node(argValue);
            internalList.insert_AtTheEnd(argValue);
            return nodeToAdd;
        }

        public Node Pop()
        {
            var retval = internalList.GetLast();
            internalList.delete_last();
            return retval;
        }

        public override string ToString()
        {
            return internalList.ToString();
        }

        public int MirroredString(string a, string b)
        {
            Stack<char> stack_a = new Stack<char>();
            Stack<char> stack_b = new Stack<char>();
            int ret = 0;

            for (int i = 0; i < a.Length; i++)
            {
                stack_a.Push(a[i]);
            }

            if (a.Length < b.Length)
            {
                for (int i = b.Length - 1; i >= 0; i--)
                {
                    stack_b.Push(b[i]);
                }
            }
            else
            {
                for (int i = 0; i < b.Length; i++)
                {
                    stack_b.Push(b[i]);
                }
            }

            int minLength = Math.Min(a.Length, b.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (stack_a.Peek() == stack_b.Peek())
                {
                    stack_a.Pop();
                    stack_b.Pop();
                    ret++;
                }
                else
                {
                    break;
                }
            }

            return ret;
        }
    }
}
