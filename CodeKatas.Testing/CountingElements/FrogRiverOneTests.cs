using CodeKatas.Logic.CountingElements;
using Xunit;

namespace CodeKatas.Testing.CountingElements
{
    public class FrogRiverOneTests
    {
        [Theory]
        [InlineData(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 6)]
        [InlineData(5, new int[] { 1, 3, 1, 4, 2, 3, 4, 5, 4 }, 7)]
        [InlineData(5, new int[] { 1, 3, 1, 1, 4, 2, 3, 4, 5, 4 }, 8)]
        [InlineData(6, new int[] { 1, 3, 1, 1, 4, 2, 3, 4, 5, 4, 6, 1 }, 10)]
        public void Test(int x, int[] input, int expectedOutput)
        {
            Assert.Equal(expectedOutput, new FrogRiverOne().Solve(x, input));
        }
    }
}
