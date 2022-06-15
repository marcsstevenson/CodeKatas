using System.Collections.Generic;
using System.Linq;

namespace CodeKatas.Logic.Arrays;

public class OddOccurrencesInArray
{
    /// <summary>
    /// Returns the only element in the array that occurs once
    /// </summary>
    public int Solve(int[] array)
    {
        var tracker = new HashSet<int>();

        foreach (var i in array)
        {
            if (tracker.Contains(i))
            {
                tracker.Remove(i);
            }
            else
            {
                tracker.Add(i);
            }
        }

        // There should only be one item in the dictionary
        return tracker.First();
    }

    public int Solve2(int[] A)
    {
        int odd = 0;
        
        for (int i = 0; i < A.Length; i++)
        {
            odd = odd ^ A[i];
        }

        return odd;
    }
}
