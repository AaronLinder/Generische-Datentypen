using LinkedList;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SwitchNodes_input1234_expected1324()
        {
            var myList = new SingleLinkedList();
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(4);

            Assert.That(myList.ToString, Is.EqualTo("1\n2\n3\n4\n"));

            myList.SwitchNodes(new Node(2), new Node(3));

            Assert.That(myList.ToString, Is.EqualTo("1\n3\n2\n4\n"));
        }

        [Test]
        public void Insertsort_UnorderdNummbers_CorrectOrderOfNumbers()
        {
            var myList = new SingleLinkedList();
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(6);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(4);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(5);

            Assert.That(myList.ToString, Is.EqualTo("1\n6\n2\n4\n3\n5\n"));

            myList.Insertsort();

            Assert.That(myList.ToString, Is.EqualTo("1\n2\n3\n4\n5\n6\n"));
        }

        [Test]

        public void Insertsort_SomeNummberDouble_CorrectOrderOfNumbersAndNoError()
        {
            var myList = new SingleLinkedList();
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(6);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(4);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(4);
            myList.insert_AtTheEnd(5);

            Assert.That(myList.ToString, Is.EqualTo("1\n6\n2\n4\n3\n4\n5\n"));

            myList.Insertsort();

            Assert.That(myList.ToString, Is.EqualTo("1\n2\n3\n4\n4\n5\n6\n"));
        }
    }
}