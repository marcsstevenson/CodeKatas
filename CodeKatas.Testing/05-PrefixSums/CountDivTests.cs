using CodeKatas.Logic.PrefixSums;
using Xunit;

namespace CodeKatas.Testing.PrefixSums;

public class CountDivTests
{

    [Theory]
    [InlineData(6, 11, 2, 3)]
    [InlineData(1, 11, 5, 2)]
    [InlineData(3, 13, 7, 1)]
    [InlineData(1, 13, 1, 13)]
    public void Test(int a, int b, int k, int expectedOutput)
    {
        Assert.Equal(expectedOutput, new CountDiv().Solve(a, b, k));
    }
}
