namespace CodeKatas.Logic.BinarySearch;

public static class BinarySearching
{
    public static int GetLargestElementLessThanX(int[] A, int x)
    {
        var n = A.Length;
        var begin = 0;
        var end = n - 1;
        int result = -1;

        while (begin <= end)
        {
            var mid = (begin + end) / 2;
            
            if (A[mid] <= x)
            {
                begin = mid + 1;
                result = mid;
            }
            else
            {
                end = mid - 1;
            }
        }

        return result;
    }
}
