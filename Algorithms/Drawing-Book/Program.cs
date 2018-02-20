using System;

internal static class Solution {
    private static int Solve(int size, int page)
    {    
        var page1 = Math.Abs(page / 2);
        
        if(size%2==0){
            size++;
        }
        
        var page2 = Math.Abs((page - size) / 2);
        
        return page1 < page2 ? page1 : page2;
        
    }

    private static void Main() {
        var n = Convert.ToInt32(Console.ReadLine());
        var p = Convert.ToInt32(Console.ReadLine());
        var result = Solve(n,p);
        Console.WriteLine(result);
    }
}
