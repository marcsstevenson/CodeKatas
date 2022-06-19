using System;
using System.Collections.Generic;
using System.Collections;
using CodeKatas.Logic.Leader;

namespace CodeKatas.Testing.Leader;

public class EquiLeaderTests
{

    [Theory]
    [ClassData(typeof(TestDataProvider))]
    public void Shall(int[] pA, int pExpected)
    {
        Assert.Equal(pExpected, new EquiLeader().solution(pA));
    }

    public class TestDataProvider : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new int[] { 4, 3, 4, 4, 4, 2 }, 2 };
            yield return new object[] { new int[] { 1, 5, 1, 5, 5, 5, 5, 5 }, 3 };
            yield return new object[] { new int[] { 1, 1, 1, 1, 1, 1 }, 5 };
            yield return new object[] { new int[] { 4, 4, 2, 5, 3, 4, 4, 4 }, 3 };
                             
            yield return new object[] { new int[] { 1, 2, 3 }, 0 };
            yield return new object[] { new int[] { 1000000000 }, 0 };
            yield return new object[] { new int[] { 1000, 1 }, 0 };
            yield return new object[] { new int[] { 0, 0 }, 1 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
