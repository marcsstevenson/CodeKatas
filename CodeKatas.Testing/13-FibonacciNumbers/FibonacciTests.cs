using CodeKatas.Logic.FibonacciNumbers;

namespace CodeKatas.Testing.FibonacciNumbers;

/// <summary>
/// Unit tests for <see cref="Fibonacci"/>
/// </summary>
public class FibonacciTests
{
    [Theory]
    [InlineData(12, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 })]
    public void Shall(int n, int[] expected)
    {
        // Act
        var result = Fibonacci.GetFibonacciNumbers(n);

        // Assert
        Assert.Equal(expected, result);
    }
}
