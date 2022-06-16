using System.Collections.Generic;
using System.Collections;
using CodeKatas.Logic.FibonacciNumbers;

namespace CodeKatas.Testing.FibonacciNumbers;

/// <summary>
/// Unit testing for <see cref="Ladder"/>
/// </summary>
public class LadderTests
{
    [Theory]
    [ClassData(typeof(TestDataProvider))]
    public void Shall(int[] A, int[] B, int[] expected)
    {
        // Act
        var actual = new Ladder().solution(A, B);

        // Assert
        Assert.Equal(expected, actual);
    }

    public class TestDataProvider : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] 
            { 
                new int[] { 4, 4, 5, 5, 1 },
                new int[] { 3, 2, 4, 3, 1 },
                new int[] { 5, 1, 8, 0, 1 },
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
