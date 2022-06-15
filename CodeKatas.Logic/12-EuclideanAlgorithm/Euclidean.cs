namespace CodeKatas.Logic.EuclideanAlgorithm;

/// <summary>
/// The Euclidean algorithm is based on the principle that the greatest common divisor of two numbers does not 
/// change if the larger number is replaced by its difference with the smaller number. For example, 21 is the 
/// GCD of 252 and 105 (as 252 = 21 × 12 and 105 = 21 × 5), and the same number 21 is also the GCD of 105 and 252 − 105 = 147. 
/// Since this replacement reduces the larger of the two numbers, repeating this process gives successively smaller pairs of 
/// numbers until the two numbers become equal. When that occurs, they are the GCD of the original two numbers.
/// </summary>
public static class Euclidean
{
    public static int GetGreatestCommonDivisor(int i, int j)
    {
        if (i % j == 0) return j;

        // Recurse
        return GetGreatestCommonDivisor(j, i % j);
    }
}