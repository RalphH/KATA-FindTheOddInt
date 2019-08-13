using System;
using Xunit;

namespace FindTheOddInt.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(5, Kata.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(-1, Kata.find_it(new[] { 1, 1, 2, -2, 5, 2, 4, 4, -1, -2, 5 }));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(5, Kata.find_it(new[] { 20, 1, 1, 2, 2, 3, 3, 5, 5, 4, 20, 4, 5 }));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal(10, Kata.find_it(new[] { 10 }));
        }

        [Fact]
        public void Test5()
        {
            Assert.Equal(10, Kata.find_it(new[] { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 }));
        }

        [Fact]
        public void Test6()
        {
            Assert.Equal(1, Kata.find_it(new[] { 5, 4, 3, 2, 1, 5, 4, 3, 2, 10, 10 }));
        }
    }
}
