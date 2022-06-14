﻿using CodeKatas.Logic.StacksAndQueues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeKatas.Testing.StacksAndQueues;

public class NestingTests
{

    [Theory]
    [InlineData("(()(())())", 1)]
    [InlineData("()", 1)]
    [InlineData("(()", 0)]
    [InlineData("(()", 0)]
    [InlineData("())", 0)]
    [InlineData("", 1)]
    [InlineData("((((", 0)]
    [InlineData("))", 0)]
    public void Shall(string S, int expected)
    {
        var actual = new Nesting().solution(S);
        Assert.Equal(expected, actual);
    }
}
