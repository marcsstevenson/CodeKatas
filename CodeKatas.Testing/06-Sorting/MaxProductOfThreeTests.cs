using CodeKatas.Logic.Sorting;
using Xunit;

namespace CodeKatas.Testing.Sorting;

public class MaxProductOfThreeTests
{
    [Theory]
    [InlineData(new int[] { -3, 1, 2, -2, 5, 6 }, 60)]
    [InlineData(new int[] { 6, 2, 5, 1, 0 }, 60)]
    [InlineData(new int[] { -6, -2, 5, 1, 0 }, 60)]
    public void Test(int[] a, int expectedOutput)
    {
        Assert.Equal(expectedOutput, new MaxProductOfThree().Solve(a));
    }
}
