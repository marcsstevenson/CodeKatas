using CodeKatas.Logic.TimeComplexity;
using Xunit;

namespace CodeKatas.Testing.TimeComplexity;

public class PassingCarsTests
{

    [Theory]
    [InlineData(new int[] { 3, 1, 2, 4, 3, }, 1)]        
    public void Test(int[] input, int expectedOutput)
    {
        Assert.Equal(expectedOutput, new TapeEquilibrium().Solve(input));
    }
}
