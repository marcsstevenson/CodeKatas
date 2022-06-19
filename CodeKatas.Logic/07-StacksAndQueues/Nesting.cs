using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKatas.Logic.StacksAndQueues;

public class Nesting
{
    public int solution(string S)
    {
        // odd numbered length cannot be valid
        if (S.Length % 2 != 0) return 0;

        // Empty is ok
        if (S.Length == 0) return 1;

        var brackets = new Dictionary<char, char>()
        {
            { '(', ')' },
        };

        var tracking = new Stack<char>();

        foreach (char c in S)
        {
            if (brackets.ContainsKey(c))
            {
                tracking.Push(c);
            }
            else
            {
                if (!tracking.Any()) return 0;

                var popped = tracking.Pop();

                // Is this a valid closing bracket?
                if (brackets[popped] != c) return 0; // Fail                
            }
        }

        // We made it this far
        if (!tracking.Any()) return 1;

        return 0;
    }
}
