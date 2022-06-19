using CodeKatas.Logic.TimeComplexity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeKatas.Testing.TimeComplexity;

public class PermutationMissingElementTests
{
    [Theory]
    [InlineData(new int[] { 1 }, 2)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 6)]
    [InlineData(new int[] { 1, 2, 2, 3, 5 }, 4)]
    [InlineData(new int[] { 1, 3 }, 2)]
    [InlineData(new int[] { 1, 2, 3, 4, 6 }, 5)]
    [InlineData(new int[] { 2, 3 }, 1)]
    [InlineData(new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 10, 11 }, 5)]
    public void Test(int[] input, int expectedOutput)
    {
        Assert.Equal(expectedOutput, new PermutationMissingElement().Solution(input));
    }
}
