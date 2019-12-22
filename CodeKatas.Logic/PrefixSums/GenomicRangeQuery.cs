using System;

namespace CodeKatas.Logic.PrefixSums
{
    public class GenomicRangeQuery
    {
        /// <summary>
        /// A DNA sequence can be represented as a string consisting of the letters A, C, G and T, which correspond to the types of successive nucleotides in the sequence. Each nucleotide has an impact factor, which is an integer. Nucleotides of types A, C, G and T have impact factors of 1, 2, 3 and 4, respectively. You are going to answer several queries of the form: What is the minimal impact factor of nucleotides contained in a particular part of the given DNA sequence?
        /// 
        /// The DNA sequence is given as a non-empty string S = S[0]S[1]...S[N - 1] consisting of N characters.There are M queries, which are given in non-empty arrays P and Q, each consisting of M integers.The K-th query(0 ≤ K<M) requires you to find the minimal impact factor of nucleotides contained in the DNA sequence between positions P[K] and Q[K] (inclusive).

        /// For example, consider string S = CAGCCTA and arrays P, Q such that:

        ///     P[0] = 2    Q[0] = 4
        ///     P[1] = 5    Q[1] = 5
        ///     P[2] = 0    Q[2] = 6
        /// The answers to these M = 3 queries are as follows:
        /// 
        /// The part of the DNA between positions 2 and 4 contains nucleotides G and C(twice), whose impact factors are 3 and 2 respectively, so the answer is 2.
        /// The part between positions 5 and 5 contains a single nucleotide T, whose impact factor is 4, so the answer is 4.
        /// The part between positions 0 and 6 (the whole string) contains all nucleotides, in particular nucleotide A whose impact factor is 1, so the answer is 1.
        /// Write a function:
        /// 
        ///     class Solution { public int[] solution(String S, int[] P, int[] Q); }
        ///
        ///     that, given a non-empty string S consisting of N characters and two non-empty arrays P and Q consisting of M integers, returns an array consisting of M integers specifying the consecutive answers to all queries.
        ///
        ///     Result array should be returned as an array of integers.
        ///
        ///
        ///     For example, given the string S = CAGCCTA and arrays P, Q such that:
        ///
        ///
        ///         P[0] = 2    Q[0] = 4
        ///     
        ///         P[1] = 5    Q[1] = 5
        ///     
        ///         P[2] = 0    Q[2] = 6
        ///     the function should return the values [2, 4, 1], as explained above.
        ///
        ///
        ///     Write an efficient algorithm for the following assumptions:
        ///
        ///
        ///     N is an integer within the range[1..100, 000];
        ///     M is an integer within the range[1..50, 000];
        /// each element of arrays P, Q is an integer within the range[0..N − 1];
        /// P[K] ≤ Q[K], where 0 ≤ K<M;
        /// string S consists only of upper-case English letters A, C, G, T.
        /// </summary>
        /// <see cref="https://app.codility.com/programmers/lessons/5-prefix_sums/genomic_range_query/"/>
        public int[] Solve(string s, int[] p, int[] q)
        {
            var nucleo = new int[s.Length + 1, 4];

            for (var count = 0; count < s.Length; count++)
            {
                if (count > 0)
                {
                    for (var index = 0; index < 4; index++)
                    {
                        nucleo[count + 1, index] += nucleo[count, index];
                    }
                }
                nucleo[count + 1, GetNucleotideImpact(s[count]) - 1]++;
            }

            var result = new int[p.Length];

            for (var count = 0; count < p.Length; count++)
            {
                // Are we examining a range of length 1?
                if (p[count] == q[count])
                {
                    // Just return the nucleotide impact of this index
                    result[count] = GetNucleotideImpact(s[p[count]]);
                }
                else
                {
                    // Examine each element of the length 4 array at index count and count + 1
                    for (var index = 0; index < 4; index++)
                    {
                        var pCount = p[count];
                        var qCountPlus1 = q[count] + 1;
                        var nucleoQCountPlus1Index = nucleo[qCountPlus1, index];
                        var nucleoPCount = nucleo[pCount, index];

                        if ((nucleoQCountPlus1Index - nucleoPCount) > 0)
                        {
                            result[count] = index + 1;
                            break;
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// A low performance solution for understanding purposes
        /// </summary>
        public int[] SolveSlowly(string a, int[] p, int[] q)
        {
            int m = p.Length;
            int[] result = new int[m];

            for (int i = 0; i < m; i++)
            {
                string subS = a.Substring(p[i], q[i] - p[i] + 1); // Get the string to examine
                char[] charSubS = subS.ToCharArray();
                Array.Sort(charSubS); // Put the lowest impact nucleotide first
                result[i] = GetNucleotideImpact(charSubS[0]); // Use the value of the first
            }

            return result;
        }

        private int GetNucleotideImpact(char nucleotide)
        {
            switch (nucleotide)
            {
                case 'A':
                    return 1;
                case 'C':
                    return 2;
                case 'G':
                    return 3;
                case 'T':
                    return 4;
                default:
                    return 0;
            }
        }
    }
}
