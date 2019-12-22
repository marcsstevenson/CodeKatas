using CodeKatas.Logic.PrefixSums;
using Xunit;

namespace CodeKatas.Testing.PrefixSums
{
    public class SortingTests
    {

        [Theory]
        [InlineData(new int[] { 4, 2, 2, 5, 1, 5, 8 }, 1)]
        public void Test(int[] a, int expectedOutput)
        {
            Assert.Equal(expectedOutput, new MinAvgTwoSlice().Solve(a));
        }

        [Theory]
        [InlineData(new int[] { 4, 2, 2, 5, 1, 5, 8 }, new int[] { 4, 6, 8, 13, 14, 19, 27 })]
        public void GetPrefixSumTest(int[] a, int[] expectedOutput)
        {
            var prefixSum = new MinAvgTwoSlice().GetPrefixSum(a);
            Assert.Equal(expectedOutput, prefixSum);
        }
    }
}
