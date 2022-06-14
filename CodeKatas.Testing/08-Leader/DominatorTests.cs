using CodeKatas.Logic.Leader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Testing.Leader;

public class DominatorTests
{
    [Theory]
    [InlineData(new int[] { 3, 4, 3, 2, 3, -1, 3, 3 }, new int[] { 0 })]
    [InlineData(new int[] { 100, 100, 100, 100, 100, 100 }, new int[] { 0 })]
    [InlineData(new int[] { 100, -1000, 100, -1000, -1000 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { -1 })]
    [InlineData(new int[] { 1000000000 }, new int[] { 0 })]
    [InlineData(new int[] { 1000, 1 }, new int[] { -1 })]
    [InlineData(new int[] { 0, 0 }, new int[] { 0 })]
    public void Shall(int[] pA, int[] options)
    {
        Assert.Contains(new Dominator().solution(pA), options);
    }
}
