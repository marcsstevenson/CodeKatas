using CodeKatas.Logic.TimeComplexity;
using Xunit;

namespace CodeKatas.Testing.TimeComplexity;

public class FrogJumpTests
{
    [Theory]
    [InlineData(0, 4, 3, 2)]
    [InlineData(3, 7, 3, 2)]
    [InlineData(5, 15, 4, 3)]
    public void Test(int x, int y, int d, int expectedOutput)
    {
        Assert.Equal(expectedOutput, new FrogJump().Solve(x, y, d));
    }
}
