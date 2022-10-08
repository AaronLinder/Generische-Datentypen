using ConsoleApp1;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LinkedList_deleteAtTest()
        {
            var myList = new SingleLinkedList<int>();
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(4);

            Assert.AreEqual(4, myList.size());

            myList.delete_at(1);
            Assert.AreEqual(3, myList.size());
        }

        [Test]
        public void LinkedList_getNode_insertafter()
        {
            var myList = new SingleLinkedList<int>();
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(5);
            myList.insert_inthemiddle(4, 4);

            Assert.That(4, Is.EqualTo(myList.get_node(4).data));
            Assert.AreEqual(5, myList.size());
        }

        [Test]
        public void getNode_NodeExists_returnsNode()
        {
            var myList = new SingleLinkedList<int>();
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(5);
            var node = myList.get_node(3);

            Assert.That(3, Is.EqualTo(node.data));
        }


    }
}