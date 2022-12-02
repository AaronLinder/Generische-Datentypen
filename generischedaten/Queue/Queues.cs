using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queues
    {
        private SingleLinkedList internalList = new SingleLinkedList();

        public Node Enqueue(int argValue)
        {
            var nodeToAdd = new Node(argValue);
            internalList.insert_AtTheEnd(argValue);
            return nodeToAdd;
        }

        public Node Dequeue()
        {
            var retval = internalList.GetFirst();
            internalList.DeleteFirst();
            return retval;
        }

        public override string ToString()
        {
            return internalList.ToString();
        }
    }
}
