using CodeKatas.Logic.MaximumSliceProblem;
using System.Collections;
using System.Collections.Generic;

namespace CodeKatas.Testing.MaximumSliceProblem;

public class MaxProfitTests
{
    [Theory]
    [ClassData(typeof(TestDataProvider))]
    public void Shall(int[] pA, int pExpected)
    {
        Assert.Equal(new MaxProfit().solution(pA), pExpected);
    }

    public class TestDataProvider : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new int[] { 4, 2, 3, 2, 5 }, 3 };
            yield return new object[] { new int[] { 1, 0, 1 }, 1 };
            yield return new object[] { new int[] { 0, 1, 0, 1 }, 1 };
            yield return new object[] { new int[] { 23171, 21011, 21123, 21366, 21013, 21367 }, 356 };
            yield return new object[] { new int[] { 23171 }, 0 };
            yield return new object[] { new int[] { }, 0 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
