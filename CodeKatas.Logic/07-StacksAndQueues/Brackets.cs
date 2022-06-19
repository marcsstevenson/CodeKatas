using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKatas.Logic.StacksAndQueues;

/// <remarks>100%</remarks>
public class Brackets
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
            { '[', ']' },
            { '{', '}' }
        };

        var stack = new Stack<char>();

        foreach (char c in S)
        {
            // Is c an opening bracket?
            if (brackets.ContainsKey(c))
            {
                stack.Push(c);
            }
            else
            { // c should be a closing bracket for the top of the stack
                if (!stack.Any()) return 0;

                var popped = stack.Pop();

                // Is this a valid closing bracket?
                if (brackets[popped] != c) return 0; // Fail                
            }
        }

        // We made it this far
        if (!stack.Any()) return 1;
        
        return 0;
    }
}
