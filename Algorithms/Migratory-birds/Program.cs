using System;
using System.Linq;
class Solution {

    static int MigratoryBirds(int[] ar)
    {
        return ar.GroupBy(x => x).OrderByDescending(x => x.Count()).ThenBy(x=>x.Key).First().Key;
    }

    static void Main() {
        Console.ReadLine();
        string[] arTemp = Console.ReadLine()?.Split(' ');
        int[] ar = Array.ConvertAll(arTemp,Int32.Parse);
        int result = MigratoryBirds(ar);
        Console.WriteLine(result);
    }
}
