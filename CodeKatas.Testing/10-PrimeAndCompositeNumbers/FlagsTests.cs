using CodeKatas.Logic.PrimeAndCompositeNumbers;

namespace CodeKatas.Testing.PrimeAndCompositeNumbers;

/// <summary>
/// Unit testing for <see cref="Flags"/>
/// </summary>
public class FlagsTests
{
    [Theory]
    [InlineData(new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 }, 3)]
    //[InlineData(new int[] { 1 }, 0)]
    //[InlineData(new int[] { 0, 1 }, 0)]
    //[InlineData(new int[] { 1, 0 }, 0)]
    //[InlineData(new int[] { 0 , 1, 0 }, 1)]
    public void Shall(int[] A, int expected)
    {
        // Act
        var result = new Flags().solution(A);

        // Assert
        Assert.Equal(expected, result);
    }
}

