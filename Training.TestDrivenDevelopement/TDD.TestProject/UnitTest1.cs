using System;
using Xunit;

namespace TDD.TestProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 6)]
        public void Test1(int data, int expectedData)
        {
            Assert.Equal(expectedData, data);
        }
    }
}
