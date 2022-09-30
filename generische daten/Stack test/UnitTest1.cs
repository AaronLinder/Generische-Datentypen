using NUnit.Framework;

namespace GenerischeKlassen

{
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);

            Assert.AreEqual(2, myStack.Pop());
        }
    }
}