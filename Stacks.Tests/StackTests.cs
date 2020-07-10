using System;
using Xunit;
using Stacks.Library;

namespace Stacks.Tests
{
    public class StacksTests
    {
        [Fact]
        public void CanPopOffItem()
        {
            var stack = new MyStack<string>();
            stack.Push("foo");
            Assert.Equal("foo", stack.Pop());
        }

        [Fact]
        public void CanPopOffMultipleItems()
        {
            var stack = new MyStack<string>()
                .Push("foo")
                .Push("bar");
            Assert.Equal("bar", stack.Pop());
            Assert.Equal("foo", stack.Pop());
        }

        [Fact]
        public void CanPopFromEmptyStringStack()
        {
            var stack = new MyStack<string>();
            Assert.Null(stack.Pop());
        }

        [Fact]
        public void CanPopFromEmptyIntStack()
        {
            var stack = new MyStack<int>();
            Assert.Equal(0, stack.Pop());
        }

    }
}
