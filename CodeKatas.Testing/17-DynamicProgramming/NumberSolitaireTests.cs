using CodeKatas.Logic.DynamicProgramming;

namespace CodeKatas.Testing.DynamicProgramming;

/// <summary>
/// Unit testing for <see cref="NumberSolitaire"/>
/// </summary>
public class NumberSolitaireTests
{
    [Theory]
    [InlineData(new int[] { 1, -2, 0, 9, -1, -2 }, 8)]
    [InlineData(new int[] { 0, 0, -1, 0, 0 }, 0)]
    [InlineData(new int[] { 0, -1, -1, -1, -1, -1, -2, -20, -20, -20, -20, -20, 0 }, -2)]
    [InlineData(new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }, -3)]
    //nlineData(new int[] { 0, -1, -1, -1, -1, -1, -2, -21, -21, -21, -20, -20, -2 }, -2)]
    public void Shall(int[] A, int expected)
    {
        // Act
        var result = new NumberSolitaire().solution(A);

        // Assert
        Assert.Equal(expected, result);
    }
}
