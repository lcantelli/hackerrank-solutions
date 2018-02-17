using System;

internal class Solution
{
    private static int divisibleSumPairs(int n, int k, int[] ar)
    {
        var possibilities = 0;
        
        for (int i = 0; i < ar.Length; i++)
        {
            for (int j = 0; j < ar.Length; j++)
            {
                if (i < j && (ar[i] + ar[j]) % k == 0)
                    possibilities++;
            } 
           
        }

        return possibilities;

    }

    private static void Main(string[] args)
    {
        var tokens_n = Console.ReadLine().Split(' ');
        var n = Convert.ToInt32(tokens_n[0]);
        var k = Convert.ToInt32(tokens_n[1]);
        var ar_temp = Console.ReadLine().Split(' ');
        var ar = Array.ConvertAll(ar_temp, int.Parse);
        var result = divisibleSumPairs(n, k, ar);
        Console.WriteLine(result);
    }
}