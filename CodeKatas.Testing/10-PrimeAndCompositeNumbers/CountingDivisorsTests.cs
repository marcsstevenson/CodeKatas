using CodeKatas.Logic.PrimeAndCompositeNumbers;

namespace CodeKatas.Testing.PrimeAndCompositeNumbers;

public class CountingDivisorsTests
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(3, 2)]
    [InlineData(5, 2)]
    [InlineData(7, 2)]
    [InlineData(4, 3)]
    [InlineData(6, 4)]
    [InlineData(24, 8)]
    [InlineData(int.MaxValue, 2)]
    public void Shall(int n, int expectedCount)
    {
        // Act
        var count = new CountingDivisors().GetDivisors(n);

        // Assert
        Assert.Equal(expectedCount, count);
    }
}
