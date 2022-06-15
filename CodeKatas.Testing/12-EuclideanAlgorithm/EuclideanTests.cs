using CodeKatas.Logic.EuclideanAlgorithm;
using System.Collections;
using System.Collections.Generic;

namespace CodeKatas.Testing.EuclideanAlgorithm;

/// <summary>
/// Unit testing for <see cref="Euclidean"/>
/// </summary>
public class EuclideanTests
{
    [Theory]
    [ClassData(typeof(TestDataProvider))]
    public void GetGreatestCommonDivisorBySubtractionShallReturnAsExpected(int i, int j, int expected)
    {
        // Act
        var actual = Euclidean.BySubtraction(i, j);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [ClassData(typeof(TestDataProvider))]
    public void Shall(int i, int j, int expected)
    {
        // Act
        var actual = Euclidean.ByDivision(i, j);

        // Assert
        Assert.Equal(expected, actual);
    }

    public class TestDataProvider : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 4, 2, 2 };
            yield return new object[] { 252, 105, 21 };
            yield return new object[] { 25, 35, 5 };
            yield return new object[] { 100, 1125, 25 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
