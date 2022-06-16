using System;
using System.Linq;

namespace CodeKatas.Logic;

public class BinaryGap
{
    public int solution(int N)
    {
        return Convert
            // convert to binary
            .ToString(N, 2)
            // remove leading and trailing 0s, as per requirement
            .Trim('0')
            // split the string by 1s
            .Split(new[] { '1' })
            // find the length of longest segment
            .Max(x => x.Length);
    }

    public int SolveLong(int n)
    {
        // convert to binary
        // remove leading and trailing 0s, as per requirement
        string bits = Convert.ToString(n, 2).Trim('0');
        //Console.WriteLine($"Bit String: {bits}");
        int longest = 0;
        int curCount = 0;

        for (int i = 0; i < bits.Length; i++)
        {
            if (bits[i] == '0')
            {
                if (curCount > 0) curCount++;
                else curCount = 1;
            }
            else curCount = 0;
            if (curCount > longest) longest = curCount;
        }

        return longest;
    }
}