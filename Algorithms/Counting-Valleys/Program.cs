using System;

internal static class Solution {
    private static int CountingValleys( string s)
    {
        var sealevel = 0;

        var hills = 0;
        
        foreach (var steps in s.ToCharArray())
        {
            bool downMarker;
            
            if (steps == 'U')
            {
                sealevel++;
                downMarker = false;
            }
            else
            {
                sealevel--;
                downMarker = true;
            }

            if (sealevel == 0 && !downMarker)
                hills++;
        }

        return hills;
    }

    private static void Main() {
        Console.ReadLine();
        var s = Console.ReadLine();
        var result = CountingValleys(s);
        Console.WriteLine(result);
    }
}
