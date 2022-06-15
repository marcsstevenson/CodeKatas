using CodeKatas.Logic.PrimeAndCompositeNumbers;

namespace CodeKatas.Testing.PrimeAndCompositeNumbers;

/// <summary>
/// Unit testing for <see cref="MinPerimeterRectangle"/>
/// </summary>
public class MinPerimeterRectangleTests
{
    [Theory]
    [InlineData(30, 22)]
    [InlineData(36, 24)]
    [InlineData(100, 40)]
    [InlineData(7, 16)]
    [InlineData(9, 12)]
    
    [InlineData(1, 4)]
    [InlineData(2, 6)]
    [InlineData(3, 8)]
    [InlineData(4, 8)]
    [InlineData(10, 14)]
    [InlineData(24, 20)]
    [InlineData(25, 20)]
    [InlineData(56, 30)]
    public void Shall(int n, int expected)
    {
        // Act
        var count = new MinPerimeterRectangle().solution(n);

        // Assert
        Assert.Equal(expected, count);
    }
}
