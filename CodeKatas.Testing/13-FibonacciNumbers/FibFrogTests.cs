using CodeKatas.Logic.FibonacciNumbers;

namespace CodeKatas.Testing.FibonacciNumbers;

/// <summary>
/// Unit testing for <see cref="FibFrog"/>
/// </summary>
public class FibFrogTests
{

    [Theory]
    [InlineData(new int[]{ 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0}, 3)]
    public void Shall(int[] A, int expected)
    {
        // Act
        var result = new FibFrog().solution(A);

        // Assert
        Assert.Equal(expected, result);
    }
}
