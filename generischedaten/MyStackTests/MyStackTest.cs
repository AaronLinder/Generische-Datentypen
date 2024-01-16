namespace MyStackTests
{
    public class MyStackTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Push_ThreeElements_StackOrderOK()
        {
            MyStack.MyStacks stack = new MyStack.MyStacks();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(stack.ToString(), "| 1 | 2 | 3 |");
        }

        [Test]
        public void PushAndPop_PushThreeTimesPoPonce_TwoElementsInStackLastOneRemoved()
        {
            MyStack.MyStacks stack = new MyStack.MyStacks();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(stack.ToString(), "| 1 | 2 | 3 |");
            stack.Pop();
            Assert.AreEqual(stack.ToString(), "| 1 | 2 |");
        }

        [Test]
        public void StringAndStringreversed_StringsMirrowed_0()
        {
            MyStack.MyStacks stack = new MyStack.MyStacks();
            string a = "abcd";
            string b = "dcba";
            int ret = stack.MirroredString(a, b);
            Assert.AreEqual(0, ret);
        }

        [Test]
        public void StringAndStringreversedDiverntLength_StringsMirrowed_4()
        {
            MyStack.MyStacks stack = new MyStack.MyStacks();
            string a = "abcde";
            string b = "dcba";
            int ret = stack.MirroredString(a, b);
            Assert.AreEqual(0, ret);
        }

        [Test]
        public void StringAndTheSameString_StringsMirrowed_1()
        {
            MyStack.MyStacks stack = new MyStack.MyStacks();
            string a = "abcde";
            string b = "dcba";
            int ret = stack.MirroredString(a, b);
            Assert.AreEqual(0, ret);
        }
    }
}