using CodeKatas.Logic.BinarySearch;

namespace CodeKatas.Testing.BinarySearch;

/// <summary>
/// Unit testing for <see cref="BinarySearching"/>
/// </summary>
public class BinarySearchTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5, 4)] // Index 4 element is 5
    [InlineData(new int[] { 1, 3, 10 }, 7, 1)] // Index 1 element is 3
    [InlineData(new int[] { 1, 9, 10 }, 7, 0)] // Index 0 element is 1
    public void Shall(int[] A, int x, int expected)
    {
        // Act
        var actual = BinarySearching.GetLargestElementLessThanX(A, x);

        // Assert
        Assert.Equal(expected, actual);
    }
}
