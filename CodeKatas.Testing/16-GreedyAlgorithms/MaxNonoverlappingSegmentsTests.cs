using CodeKatas.Logic.GreedyAlgorithms;

namespace CodeKatas.Testing.GreedyAlgorithms;

/// <summary>
/// Unit testing for <see cref="MaxNonoverlappingSegments"/>
/// </summary>
public class MaxNonoverlappingSegmentsTests
{
    [Theory]
    [InlineData(new int[] { 1, 3, 7, 9, 9 }, new int[] { 5, 6, 8, 9, 10 }, 3)]
    //[InlineData(new int[] { 1, 2 }, new int[] { 10, 12 }, 1)]
    public void Shall(int[] A, int[] B, int expected)
    {
        // Act
        var result = new MaxNonoverlappingSegments().solution(A, B);

        // Assert
        Assert.Equal(expected, result);
    }
}
