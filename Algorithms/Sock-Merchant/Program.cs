using System;
using System.Collections.Generic;
using System.Linq;

internal class Solution
{
    private static int SockMerchant(IEnumerable<int> ar)
    {
        return ar.GroupBy(a => a).Sum(a => a.Count() / 2);
    }

    private static void Main()
    {
        Console.ReadLine();
        var arTemp = Console.ReadLine()?.Split(' ');
        var ar = Array.ConvertAll(arTemp, int.Parse);
        var result = SockMerchant(ar);
        Console.WriteLine(result);
    }
}