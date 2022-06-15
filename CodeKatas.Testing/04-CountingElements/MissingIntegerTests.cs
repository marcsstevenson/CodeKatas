using CodeKatas.Logic.CountingElements;
using Xunit;

namespace CodeKatas.Testing.CountingElements;

public class MissingIntegerTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 4 }, 3)]
    [InlineData(new int[] { 1, 2, 3, 4, 6 }, 5)]
    [InlineData(new int[] { 1, 4, 3, 6, 6, 1, 2, 4 }, 5)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 5)]
    [InlineData(new int[] { 4, 3, 2, 1 }, 5)]
    [InlineData(new int[] { 1, 2, 3, 4, 3, 2, 1 }, 5)]
    [InlineData(new int[] { 1, 2, 3, 4, 3, 5, 6, 8, 2, 1 }, 7)]
    [InlineData(new int[] { }, 1)]
    [InlineData(new int[] { 1 }, 2)]
    [InlineData(new int[] { 2 }, 1)]
    [InlineData(new int[] { 2, 4 }, 1)]
    [InlineData(new int[] { 2, 4, 1, 6, 9, 3 }, 5)]
    [InlineData(new int[] { -1, -3 }, 1)]
    public void Test(int[] input, int expectedOutput)
    {
        Assert.Equal(expectedOutput, new MissingInteger().SolveWithLinq(input));
        //Assert.Equal(expectedOutput, new MissingInteger().Solve(input));
    }
}
