using System;
using Xunit;

namespace TestingTestingLibrary
{
    public class TestTestLib
    {
        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(-3, -1, -2)]
        public void TestAdd(int ans, int a, int b)
        {
            Assert.Equal(ans, TestLibrary.TestLib.Add(a, b));
        }

        [Theory]
        [InlineData(5, 8, 3)]
        [InlineData(2, -8, -10)]
        public void TestSub(int ans, int a, int b)
        {
            Assert.Equal(ans, TestLibrary.TestLib.Sub(a, b));
        }

        [Theory]
        [InlineData(25, 5, 5)]
        [InlineData(30, 10, 3)]
        [InlineData(0, 50, 0)]
        [InlineData(-24, -6, 4)]
        [InlineData(56, -8, -7)]
        public void TestMult(int ans, int a, int b)
        {
            Assert.Equal(ans, TestLibrary.TestLib.Mult(a, b));
        }

        [Fact]
        public void TestPI()
        {
            Assert.Equal(3.1415926m, TestLibrary.TestLib.PI);
        }
    }
}
