using CodeKatas.Logic.BinarySearch;

namespace CodeKatas.Testing.BinarySearch;

/// <summary>
/// Unit tests for <see cref="MinMaxDivision"/>
/// </summary>
public class MinMaxDivisionTests
{
    [Theory]
    [InlineData(3, 5, new int[] { 2, 1, 5, 1, 2, 2, 2 }, 6)]
    public void Shall(int K, int M, int[] A, int expected)
    {
        // Act
        var actual = new MinMaxDivision().solution(K, M, A);

        // Assert
        Assert.Equal(expected, actual);
    }
}
