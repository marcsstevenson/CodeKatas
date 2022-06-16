using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKatas.Logic.FibonacciNumbers;
/*

The number of options per rung is a Fibonacci sequence ;)
where L rungs has fib(

N = 1
1
=> 1 way

N = 2
11
2
=> 2 ways

N = 3
111
12
21
=> 3 ways

N = 4 
1111
112
121
211
22
=> 5 ways

N = 5
11111
1112
1121
1211
2111
221
212
122
=> 8 ways

For example, given L = 5 and:

    A[0] = 4   B[0] = 3 => 5 (fib(4 + 2) % 2^3) => 5 % 8 = 5
    A[1] = 4   B[1] = 2 => 1 (fib(4 + 2) % 2^2) => 5 % 4 = 1
    A[2] = 5   B[2] = 4 => 1 (fib(5 + 2) % 2^8) => 8 % 16 = 1
    A[3] = 5   B[3] = 3 => 0 (fib(5 + 2) % 2^3) => 8 % 8 = 0
    A[4] = 1   B[4] = 1 => 1 (fib(1 + 2) % 2^1) => 1 % 2 = 1

the function should return the sequence [5, 1, 8, 0, 1], as explained above.

*/


public class Ladder
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="A">The number of rungs which has fib(A[i]) ways of ascending the ladder</param>
    /// <param name="B"></param>
    /// <remarks>
    /// 50% and failing performance area :/
    /// </remarks>
    public int[] solution(int[] A, int[] B)
    {
        var length = A.Length;
        var results = new List<int>();
        // Get all of the Fibonacci numbers up until the max needed
        var fibs = Fibonacci.GetFibonacciNumbersAsListWithMod(A.Max() + 2);

        for (int i = 0; i < length; i++)
        {
            var numberOfRungs = A[i];
            var numberOfWays = (int)fibs[numberOfRungs + 1];
            var twopB = (int)Math.Pow(2, B[i]);
            var result = (numberOfWays % twopB);
            results.Add(result);
        }

        return results.ToArray();
    }    
}
