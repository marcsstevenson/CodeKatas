using CodeKatas.Logic.EuclideanAlgorithm;

namespace CodeKatas.Testing.EuclideanAlgorithm;

/// <summary>
/// Unit testing for <see cref="CommonPrimeDivisors"/>
/// </summary>
public class CommonPrimeDivisorsTests
{
    [Theory]
    [InlineData(new int[] { 15, 10, 3 }, new int[] { 75, 30, 5 }, 1)]
    public void Shall(int[] A, int[] B, int expected)
    {
        // Act
        var result = new CommonPrimeDivisors().solution(A, B);

        // Assert
        Assert.Equal(expected, result);
    }
}
