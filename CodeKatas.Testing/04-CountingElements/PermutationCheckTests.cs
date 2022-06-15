using CodeKatas.Logic.CountingElements;
using Xunit;

namespace CodeKatas.Testing.CountingElements;

public class PermutationCheckTests
{
    [Theory]
    [InlineData(new uint[] { 3, 1, 2, 4, 5 }, 1)]
    [InlineData(new uint[] { 3, 3, 2, 2, 5 }, 0)]
    [InlineData(new uint[] { 3, 3, 4, 5 }, 0)]
    [InlineData(new uint[] { 3, 1, 4, 5 }, 0)]
    [InlineData(new uint[] { 1, 2, 4, 5 }, 0)]
    [InlineData(new uint[] { 3, 1, 2, 4 }, 1)]
    [InlineData(new uint[] { 4, 1, 3, 2 }, 1)]
    [InlineData(new uint[] { 4, 1, 3 }, 0)]
    public void Test(uint[] input, int expectedOutput)
    {
        Assert.Equal(expectedOutput, new PermutationCheck().Solve(input));
    }
}
