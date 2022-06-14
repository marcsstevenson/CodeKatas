using CodeKatas.Logic.StacksAndQueues;

namespace CodeKatas.Testing.StacksAndQueues;

public class StoneWallTests
{

    [Theory]
    [InlineData(new int[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 }, 7)]
    [InlineData(new int[] { 8, 8, 5, 7, 9, 8, 7, 5, 8 }, 6)]
    [InlineData(new int[] { 1, 2, 3, 4, 3 }, 4)]
    [InlineData(new int[] { 8, 8, 5 }, 2)]
    [InlineData(new int[] { 8, }, 1)]
    [InlineData(new int[] { 8, 8 }, 1)]
    [InlineData(new int[] { 8, 8, 8, 8, 8 }, 1)]
    [InlineData(new int[] { 1000000000 }, 1)]
    [InlineData(new int[] { 1000000000, 2 }, 2)]
    [InlineData(new int[] { 2, 1000000000, 2 }, 2)]
    [InlineData(new int[] { 2, 1000000000, 2, 1000000000 }, 3)]
    [InlineData(new int[] { 2, 1000000000, 2, 1000000000, 1000000000 }, 3)]
    public void Shall(int[] heights, int expectedResult)
    {
        var stoneWall = new StoneWall();
        Assert.Equal(expectedResult, stoneWall.Solution(heights));
    }
}
