using CodeKatas.Logic.PrimeAndCompositeNumbers;
using CodeKatas.Logic.SieveOfEratosthenes;
using System.Collections;
using System.Collections.Generic;

namespace CodeKatas.Testing.PrimeAndCompositeNumbers;

/// <summary>
/// Unit testing for <see cref="CountSemiprimes"/>
/// </summary>
public class CountSemiprimesTests
{
    [Theory]
    [ClassData(typeof(TestDataProvider))]
    public void Shall(int N, int[] P, int[] Q, int[] expected)
    {
        // Act
        var result = new CountSemiprimes().solution(N, P, Q);

        // Assert
        Assert.Equal(expected, result);
    }

    public class TestDataProvider : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] 
            { 
                26, 
                new int[] { 1, 4, 16 }, 
                new int[] { 26, 10, 20 },
                new int[] {10, 4, 0 },
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}

