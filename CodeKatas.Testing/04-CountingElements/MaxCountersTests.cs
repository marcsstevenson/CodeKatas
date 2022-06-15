using CodeKatas.Logic.CountingElements;
using Xunit;

namespace CodeKatas.Testing.CountingElements;

public class MaxCountersTests
{
    [Theory]
    [InlineData(5, new int[] { 3, 4, 4, 6, 1, 4, 4 }, new int[] { 3, 2, 2, 4, 2 })]
    public void Test(int n, int[] input, int[] expectedOutput)
    {
        Assert.Equal(expectedOutput, new MaxCounters().Solve(n, input));
    }
}
