using CodeKatas.Logic;
using CodeKatas.Logic.Arrays;
using System;
using Xunit;

namespace CodeKatas.Testing.Arrays;

public class OddOccurrencesInArrayTests
{
    [Theory]
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6 ,8 }, 7)]
    public void Test(int[] input, int expectedOutput)
    {
        Assert.Equal(expectedOutput, new OddOccurrencesInArray().Solve(input));
    }
}
