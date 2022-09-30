using ConsoleApp1;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /*[Test]
        public void Stack_ifpop_equals()
        {
            var myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);


            Assert.AreEqual(3, myStack.Count());
            Assert.AreEqual(myStack.Pop(), 3);
            Assert.AreEqual(myStack.Pop(), 2);
        }*/

        [Test]
        public void LinkedList_test()
        {
            var myList = new SingleLinkedList();
            myList.insert(1);
            myList.insert(2);
            myList.insert(3);


            Assert.AreEqual(3, myList.size());

            myList.delete_last();
            Assert.AreEqual(2, myList.size());
        }
    }
}