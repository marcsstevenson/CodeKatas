using CodeKatas.Logic.PrefixSums;
using Xunit;

namespace CodeKatas.Testing.PrefixSums
{
    public class GenomicRangeQueryTests
    {

        [Theory]
        [InlineData("CAGCCTA", new int[] { 2, 5, 0 }, new int[] { 4, 5, 6 }, new int[] { 2, 4, 1 })]
        //[InlineData("CAGCCTA", new int[] { 0, 3, 4, 4 }, new int[] { 2, 5, 4, 6 }, new int[] { 1, 2, 2, 1 })]
        //[InlineData("CAGCCTA", new int[] { 3, 1, 0, 4 }, new int[] { 3, 4, 4, 5 }, new int[] { 2, 1, 1, 2 })]
        public void Test(string s, int[] p, int[] q, int[] expectedOutput)
        {
            Assert.Equal(expectedOutput, new GenomicRangeQuery().SolveSlowly(s, p, q));
        }
    }
}
