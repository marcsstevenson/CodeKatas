using CodeKatas.Logic.CaterpillarMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Testing.CaterpillarMethod;

public class CountTrianglesTests
{

    [Theory]
    [InlineData(new int[] { 10, 2, 5, 1, 8, 12 }, 4)]
    public void Shall(int[] A, int expected)
    {
        // Act
        var result = Caterpillar.GetNumberOfTriangles(A);

        // Assert
        Assert.Equal(expected, result);
    }
}
