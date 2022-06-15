using CodeKatas.Logic.PrimeAndCompositeNumbers;

namespace CodeKatas.Testing.PrimeAndCompositeNumbers;

/// <summary>
/// Unit testing for <see cref="Primality"/>
/// </summary>
public class PrimalityTests
{
    [Theory]
    [InlineData(1, false)]
    [InlineData(3, true)]
    [InlineData(5, true)]
    [InlineData(7, true)]
    [InlineData(4, false)]
    [InlineData(6, false)]
    public void Shall(int n, bool expected)
    {
        // Act
        var count = Primality.GetPrimality(n);

        // Assert
        Assert.Equal(expected, count);
    }
}
