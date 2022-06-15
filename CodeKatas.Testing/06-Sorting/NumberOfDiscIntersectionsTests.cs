using CodeKatas.Logic.Sorting;
using Xunit;

namespace CodeKatas.Testing.Sorting;

public class NumberOfDiscIntersectionsTests
{
    [Theory]
    [InlineData(new int[] { 1, 5, 2, 1, 4, 0 }, 11)]
    public void Test(int[] a, int expectedOutput)
    {
        Assert.Equal(expectedOutput, new NumberOfDiscIntersections().Solve(a));
    }
}
