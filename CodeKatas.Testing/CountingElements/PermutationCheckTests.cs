using CodeKatas.Logic.CountingElements;
using Xunit;

namespace CodeKatas.Testing.CountingElements
{
    public class PermutationCheckTests
    {
        [Theory]
        [InlineData(new int[] { 3, 1, 2, 4, 5 }, 1)]
        [InlineData(new int[] { 3, 3, 2, 2, 5 }, 0)]
        [InlineData(new int[] { 3, 3, 4, 5 }, 0)]
        [InlineData(new int[] { 3, 1, 4, 5 }, 0)]
        [InlineData(new int[] { 1, 2, 4, 5 }, 0)]
        [InlineData(new int[] { 3, 1, 2, 4 }, 1)]
        [InlineData(new int[] { 4, 1, 3, 2 }, 1)]
        [InlineData(new int[] { 4, 1, 3 }, 0)]
        public void Test(int[] input, int expectedOutput)
        {
            Assert.Equal(expectedOutput, new PermutationCheck().Solve(input));
        }
    }
}
