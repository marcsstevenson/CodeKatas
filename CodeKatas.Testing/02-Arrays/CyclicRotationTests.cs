using CodeKatas.Logic.Arrays;
using Xunit;

namespace CodeKatas.Testing.Arrays
{
    public class CyclicRotationTests
    {
        [Theory]
        [InlineData(new int[] { 1 }, 1, new int[] { 1 })]
        [InlineData(new int[] { 1, 2 }, 1, new int[] { 2, 1 })]
        [InlineData(new int[] { 1, 2, 3 }, 1, new int[] { 3, 1, 2 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 3, new int[] { 4, 5, 6, 1, 2, 3 })]
        [InlineData(new int[] { 3, 8, 9, 7, 6 }, 3, new int[] { 9, 7, 6, 3, 8 })]
        public void Test(int[] input, int rotations, int[] expectedOutput)
        {
            Assert.Equal(expectedOutput, new CyclicRotation().Solve(input, rotations));
        }
    }
}
