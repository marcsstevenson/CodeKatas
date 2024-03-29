﻿namespace CodeKatas.Logic.EuclideanAlgorithm;

public class ChocolatesByNumbers
{
    public int solution(int N, int M)
    {
        var gcd = Euclidean.ByDivision(N, M);
        return N / gcd;
    }
}
