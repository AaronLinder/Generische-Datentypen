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
        public void LinkedList_test()
        {
            var myList = new SingleLinkedList<int>();
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(3);



            Assert.AreEqual(3, myList.size());

            myList.delete_last();
            Assert.AreEqual(2, myList.size());
        }
    }
}