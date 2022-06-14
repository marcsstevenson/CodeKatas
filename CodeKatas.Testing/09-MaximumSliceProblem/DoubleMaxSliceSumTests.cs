using CodeKatas.Logic.MaximumSliceProblem;
using System.Collections;
using System.Collections.Generic;

namespace CodeKatas.Testing.MaximumSliceProblem;

public class DoubleMaxSliceSumTests
{
    [Theory]
    [ClassData(typeof(TestDataProvider))]
    public void Shall(int[] pA, int pExpected)
    {
        Assert.Equal(new DoubleMaxSliceSum().solution(pA), pExpected);
    }

    public class TestDataProvider : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new int[] { 3, 2, 6, -1, 4, 5, -1, 2 }, 17 };
            yield return new object[] { new int[] { -2 - 3, 4, -1, -2, 1, 5, -3 }, 9 };
            yield return new object[] { new int[] { 1, 2, 3 }, 0 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
