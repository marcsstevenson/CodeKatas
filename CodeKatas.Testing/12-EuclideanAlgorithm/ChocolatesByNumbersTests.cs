using CodeKatas.Logic.EuclideanAlgorithm;

namespace CodeKatas.Testing.EuclideanAlgorithm;

/// <summary>
/// Unit testing for <see cref="ChocolatesByNumbers"/>
/// </summary>
public class ChocolatesByNumbersTests
{

    [Theory]
    [InlineData(10, 4, 5)]
    [InlineData(10, 3, 10)]
    [InlineData(5, 6, 5)]
    [InlineData(5, 7, 5)]
    [InlineData(1, 1, 1)]
    [InlineData(2, 1, 2)]
    [InlineData(100, 1, 100)]
    public void Shall(int N, int M, int expected)
    {
        // Act
        var result = new ChocolatesByNumbers().solution(N, M);

        // Assert
        Assert.Equal(expected, result);
    }
}
