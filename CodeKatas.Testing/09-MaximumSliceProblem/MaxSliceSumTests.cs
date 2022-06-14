using CodeKatas.Logic.MaximumSliceProblem;
using System.Collections;
using System.Collections.Generic;

namespace CodeKatas.Testing.MaximumSliceProblem;

public class MaxSliceSumTests
{
    [Theory]
    [ClassData(typeof(TestDataProvider))]
    public void Shall(int[] pA, int pExpected)
    {
        Assert.Equal(new MaxSliceSum().solution(pA), pExpected);
    }

    public class TestDataProvider : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new int[] { 5, -7, 3, 5, -2, 4, -1 }, 10 };
            yield return new object[] { new int[] { -2, -3, 4, -1, -2, 1, 5, -3 }, 7 };
            yield return new object[] { new int[] { 3, 2, -6, 4, 0 }, 5 };
            yield return new object[] { new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
