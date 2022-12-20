using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace CodeKatas.Logic.FibonacciNumbers;

public class FibFrog
{
    public class Jump
    {
        public Jump(int position, int counter)
        {
            Position = position;
            Counter = counter;
        }

        public int Position { get; }
        public int Counter { get; }
    }

    public int solution_new(int[] A)
    {
        // Refer here for full solution: https://www.youtube.com/watch?v=KAfCjYcYJeM&list=PLTMybUaeagJbTAelBd-pGBuAngpPtnw8b
        var length = A.Length;        
        List<int> fibNums = Fibonacci.GetFibonacciNumbersAsList(length, length + 1);

        int steps = 0;
        List<int> positions = new() { -1 };

        while (positions.Any())
        {
            steps++;

            if (AttemptJump(fibNums, ref positions, A.Length, A))
            {
                return steps;
            }
        }

        return -1;
    }

    public bool AttemptJump(List<int> fibNums, ref List<int> positions, int target, int[] A)
    {
        List<int> newPositions = new();

        for (int position = 0; position  < positions.Count; position ++)
        {
            for (int i = fibNums.Count - 1; i >= 2; i--)
            {
                int fibNum = fibNums[i];

                if (position + fibNum == target)
                {
                    return true;
                }

                if (position + fibNum < target)
                {
                    if (A[position + fibNum] == 1)
                    {
                        A[position + fibNum] = 0; // We have used this leaf so remove it
                        newPositions.Add(position + fibNum);
                    }
                }
            }
        }

        positions = newPositions;

        return false;
    }

    /// <summary>
    /// 75%
    /// </summary>
    public int solution(int[] A)
    {
        var length = A.Length;

        // Handle corner case
        if (length == 0)
            return 1;

        List<int> fibs = Fibonacci.GetFibonacciNumbersAsList(length, length + 1);

        bool[] accessed = new bool[length]; // Take used leaves
        List<Jump> jumps = new List<Jump>();

        jumps.Add(new Jump(-1, 0)); // Initial position

        Jump currentJump;
        int step = 0;

        while (true)
        {
            if (step == jumps.Count)
            {
                return -1; // No valid result
            }

            currentJump = jumps[step];
            step++;

            foreach (var fibOption in fibs)
            {
                var candidate = currentJump.Position + fibOption;
                // Does this fibOption take us to the end?
                if (candidate == length)
                {
                    return currentJump.Counter + 1; // Return the successful number of jumps which is one more than the current jump
                }
                else if (
                    candidate < 0
                    || candidate > length // Too long
                    || A[candidate] == 0 // No leaf at position
                    || accessed[candidate]) // Leaf already used
                {
                    // Keep looking for a valid jump
                    continue;
                }

                // Add a new jump
                jumps.Add(new Jump(candidate, currentJump.Counter + 1));

                // Record the accessed position
                accessed[candidate] = true;
            }
        }
    }
}
