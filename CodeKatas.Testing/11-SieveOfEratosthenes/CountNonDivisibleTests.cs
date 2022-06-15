using CodeKatas.Logic.PrimeAndCompositeNumbers;
using CodeKatas.Logic.SieveOfEratosthenes;

namespace CodeKatas.Testing.PrimeAndCompositeNumbers;

/// <summary>
/// Unit testing for <see cref="CountNonDivisible"/>
/// </summary>
public class CountNonDivisibleTests
{
    [Theory]
    [InlineData(new int[] { 3, 1, 2, 3, 6 }, new int[] { 2, 4, 3, 2, 0 })]
    public void Shall(int[] A, int[] expected)
    {
        // Act
        var result = new CountNonDivisible().solution(A);

        // Assert
        Assert.Equal(expected, result);
    }
}

