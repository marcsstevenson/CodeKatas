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
    public void Shall(uint n, uint expectedCount)
    {
        // Act
        var count = new CountingDivisors().GetDivisors(n);

        // Assert
        Assert.Equal(expectedCount, count);
    }
}
