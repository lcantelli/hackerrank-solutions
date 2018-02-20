using System;
using System.Linq;

namespace Solution
{
    internal static class Solution
    {
        private static void Main()
        {
            var nk = Console.ReadLine();
            var k = Convert.ToInt32(nk?.Split(' ')[1]);

            var b = Console.ReadLine()
                ?.Split(' ')
                .ToList()
                .Select(x => Convert.ToInt32(x))
                .ToList();

            var bill = Convert.ToInt32(Console.ReadLine());

            b?.RemoveAt(k);

            var share = (b ?? throw new Exception()).Sum(x => x) / 2;

            Console.WriteLine(share == bill ? "Bon Appetit" : (bill - share).ToString());
        }
    }
}