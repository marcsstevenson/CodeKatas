using CodeKatas.Logic.TimeComplexity;
using Xunit;

namespace CodeKatas.Testing.TimeComplexity
{
    public class TapeEquilibriumTests
    {

        [Theory]
        [InlineData(new int[] { 3, 1, 2, 4, 3, }, 1)]        
        public void Test(int[] input, int expectedOutput)
        {
            Assert.Equal(expectedOutput, new TapeEquilibrium().Solve(input));
        }
    }
}
