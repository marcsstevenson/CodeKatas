using CodeKatas.Logic.Sorting;
using Xunit;

namespace CodeKatas.Testing.Sorting
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(new int[] { 10, 2, 5, 1, 8, 20 }, 1)]
        [InlineData(new int[] { 10, 2, 5, int.MaxValue, int.MaxValue, int.MaxValue }, 1)]
        public void Test(int[] a, int expectedOutput)
        {
            Assert.Equal(expectedOutput, new Triangle().Solve(a));
        }
    }
}
