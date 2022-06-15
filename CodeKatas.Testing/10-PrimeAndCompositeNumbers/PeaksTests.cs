using CodeKatas.Logic.PrimeAndCompositeNumbers;

namespace CodeKatas.Testing.PrimeAndCompositeNumbers;

/// <summary>
/// Unit testing for <see cref="Peaks"/>
/// </summary>
public class PeaksTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 }, 3)]
    public void Shall(int[] A, int expected)
    {
        // Act
        var result = new Peaks().solution(A);

        // Assert
        Assert.Equal(expected, result);
    }
}

