using System.Collections.Generic;
using System.Linq;

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
