using CodeKatas.Logic.CountingElements;
using Xunit;

namespace CodeKatas.Testing.CountingElements
{
    public class MissingIntegerTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 4 }, 3)]
        [InlineData(new int[] { 1, 2, 3, 4, 6 }, 5)]
        [InlineData(new int[] { 1, 4, 3, 6, 6, 1, 2, 4 }, 5)]
        [InlineData(new int[] { 1, 2, 3, 4 }, 5)]
        [InlineData(new int[] { }, 1)]
        [InlineData(new int[] { 1 }, 2)]
        [InlineData(new int[] { 2 }, 1)]
        public void Test(int[] input, int expectedOutput)
        {
            Assert.Equal(expectedOutput, new MissingInteger().Solve(input));
        }
    }
}
