using CodeKatas.Logic.GreedyAlgorithms;

namespace CodeKatas.Testing.GreedyAlgorithms;

/// <summary>
/// Unit testing for <see cref="TieRopes"/>
/// </summary>
public class TieRopesTests
{
    [Theory]
    [InlineData(4, new int[] { 1, 2, 3, 4, 1, 1, 3 }, 3)]
    public void Shall(int K, int[] A, int expected)
    {
        // Act
        var result = new TieRopes().solution(K, A);

        // Assert
        Assert.Equal(expected, result);
    }
}
