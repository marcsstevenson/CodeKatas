using CodeKatas.Logic.EuclideanAlgorithm;

namespace CodeKatas.Testing.EuclideanAlgorithm;

/// <summary>
/// Unit testing for <see cref="Euclidean"/>
/// </summary>
public class EuclideanTesting
{

    [Theory]
    [InlineData(252, 105, 21)]
    public void Shall(int i, int j, int expected)
    {
        // Act
        var actual = Euclidean.GetGreatestCommonDivisor(i, j);

        // Assert
        Assert.Equal(expected, actual);
    }
}
