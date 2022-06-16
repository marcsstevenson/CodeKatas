using CodeKatas.Logic.CaterpillarMethod;

namespace CodeKatas.Testing.CaterpillarMethod;

/// <summary>
/// Unit testing for <see cref="Caterpillar"/>
/// </summary>
public class CaterpillarTests
{

    [Theory]
    [InlineData(new int[] { }, 1, false)]
    [InlineData(new int[] { 1 }, 1, true)]
    [InlineData(new int[] { 1 }, 2, false)]
    [InlineData(new int[] { 5, 1, 0, 0, 1, 4 }, 2, true)]
    [InlineData(new int[] { 5, 1, 0, 10, 1, 4, 1 }, 13, false)]
    [InlineData(new int[] { 5, 1, 0, 10, 1, 1, 7 }, 13, true)]
    public void HasSebsequenceOfSumShallReturnAsExpected(int[] A, int sum, bool expected)
    {
        // Act
        var result = new Caterpillar().HasSebsequenceOfSum(A, sum);

        // Assert
        Assert.Equal(expected, result);
    }
}
