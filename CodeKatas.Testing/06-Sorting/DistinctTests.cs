using CodeKatas.Logic.Sorting;
using Xunit;

namespace CodeKatas.Testing.Sorting;

public class DistinctTests
{
    [Theory]
    [InlineData(new int[] { 2, 1, 1, 2, 3, 1 }, 3)]
    [InlineData(new int[] { 1, 1, 3, 3, 1, 4, 8 }, 4)]
    public void Test(int[] a, int expectedOutput)
    {
        Assert.Equal(expectedOutput, new Distinct().Solve(a));
    }
}
