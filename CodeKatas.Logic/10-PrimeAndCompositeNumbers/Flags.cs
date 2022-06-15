using System;
using System.Collections.Generic;

namespace CodeKatas.Logic.PrimeAndCompositeNumbers;

public class Flags
{
    public int solution(int[] A)
    {
        var peaks = new List<int>();
        for (int i = 1; i < A.Length - 1; i++)
        {
            if (A[i - 1] < A[i] && A[i + 1] < A[i])
            {
                peaks.Add(i);
            }
        }
        
        // Handle corner cases
        if (peaks.Count == 1 || peaks.Count == 0)
        {
            return peaks.Count;
        }

        int sf = 1;
        int ef = peaks.Count;
        int result = 1;
        
        while (sf <= ef)
        {
            int flag = (sf + ef) / 2;
            bool success = false;
            int used = 0;
            int mark = peaks[0];
            for (int i = 0; i < peaks.Count; i++)
            {
                if (peaks[i] >= mark)
                {
                    used++;
                    mark = peaks[i] + flag;
                    if (used == flag)
                    {
                        success = true; // We can plant a flag
                        break;
                    }
                }
            }
            
            if (success)
            { // Plant flag
                result = flag;
                sf += flag;
            }
            else
            {
                ef = flag - 1;
            }
        }
        return result;
    }

    #region FailTrail

    public int solutionNotFromPy(int[] A)
    {
        var N = A.Length;
        var next = GetNextPeak(A);
        var i = 1;
        var result = 0;

        while ((i - 1) * i <= N)
        {
            var pos = 0;
            var num = 0;

            while (pos < N && num < 1)
            {
                pos = next[pos];

                if (pos == -1) break;

                num++;
                pos += i;

            }

            result = Math.Max(result, num);
            i++;

        }

        return result;
    }

    public int[] GetNextPeak(int[] A)
    {
        var N = A.Length;
        var peaks = GetPeaks(A);

        var nextPeak = new int[N];
        nextPeak[N - 1] = -1;

        for (var i = N - 2; i > 0; i--) // Same as in Python? for i in xrange(N - 2, -1, -1):
        {
            if (peaks[i])
                nextPeak[i] = i;
            else
                nextPeak[i] = nextPeak[i + 1];
        }

        return nextPeak;
    }

    public bool[] GetPeaks(int[] A)
    {
        var N = A.Length;
        var peaks = new bool[N];

        // Get all peaks where neighbours are shorter
        for (var i = 1; i < N - 1; i++)
        {
            if (A[i - 1] < A[i] && A[i] > A[i + 1])
                peaks[i] = true;
        }

        return peaks;
    }

    public bool CanCreateFlags(int x, int[] A)
    {
        var N = A.Length;
        var peaks = GetPeaks(A);
        var flags = x;
        var pos = 0;

        while (pos < N && flags > 0)
        {
            if (peaks[pos]) // Is there a peak at this position?
            {
                flags--; // Flag has been set
                pos += x;
            }
            else
                pos++;
        }

        return flags == 0; // Were all of the flags set?
    }

    /// <summary>
    /// Fails some test cases
    /// </summary>
    public int solutionNot(int[] A)
    {
        var peaks = new List<int>();

        // Get all peaks where neighbours are shorter
        for (var i = 1; i < A.Length - 1; i++)
        {
            if (A[i - 1] < A[i] && A[i] > A[i + 1])
                peaks.Add(i);
        }

        // Handle corner case
        if (peaks.Count < 2)
            return peaks.Count;

        // Start from the square root
        var root = Math.Floor(Math.Sqrt(peaks[peaks.Count - 1] - peaks[0]));

        var flags = 1;

        for (var i = root + 1; i > 0; i--)
        {
            var distanceSum = 0;
            for (var j = 0; j < peaks.Count - 1; j++)
            {
                var currentPeak = peaks[j];
                var nextPeak = peaks[j + 1];

                var peakDifference = Math.Abs(nextPeak - currentPeak);

                if ((peakDifference + distanceSum) >= i)
                {
                    flags++;
                    distanceSum = 0;
                }

                else
                    distanceSum += peakDifference;
                if (flags == i)
                    return flags;
            }
        }

        return flags;
    }

    #endregion
}
