using CodeKatas.Logic.PrefixSums;
using Xunit;

namespace CodeKatas.Testing.PrefixSums
{
    public class PassingCarsTests
    {

        [Theory]
        [InlineData(new int[] { 0, 1, 0, 1, 1 }, 5)]
        [InlineData(new int[] { 1, 1, 0, 1, 1, 0 }, 2)]
        [InlineData(new int[] { 0, 1, 1, 0, 1, 1, 0 }, 6)]
        public void Test(int[] input, int expectedOutput)
        {
            Assert.Equal(expectedOutput, new PassingCars().Solve(input));
        }
    }
}
