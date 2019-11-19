using CodeKatas.Logic;
using System;
using Xunit;

namespace CodeKatas.Testing
{
    public class BinaryGapTests
    {
        [Theory]
        [InlineData(40, 1)] //101000
        [InlineData(96, 0)] //1100000
        [InlineData(20, 1)] //10100
        [InlineData(100, 2)] //1100100
        [InlineData(1, 0)] //1
        [InlineData(529, 4)] //1000010001
        [InlineData(32, 0)] //100000
        public void BinaryGapsShallReturnAsExpected(int input, int expectedOutput)
        {
            Assert.Equal(expectedOutput, new BinaryGap().Solve(input));
        }
    }
}
