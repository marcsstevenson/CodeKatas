using CodeKatas.Logic.StacksAndQueues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Testing.StacksAndQueues;

/// <summary>
/// Unit testing for <see cref="Fish"/>
/// </summary>
public class FishTests
{
    [Theory]
    [InlineData(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 0, 0, 0 }, 2)]
    public void Shall(int[] A, int[] B, int value)
    {
        // Act
        var result = new Fish().solution(A, B);

        // Assert
        Assert.Equal(value, result);
    }
}
