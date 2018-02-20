using System;

internal class Solution
{
    private static string Solve(int year)
    {
        var dayMonth = "26.09.";

        if (IsLeap(year))
            dayMonth = "12.09.";
        else if(year != 1918)
        {
            dayMonth = "13.09.";
        }

        return dayMonth + year;
    }

    private static bool IsLeap(int year)
    {
        if (year % 4 != 0) return false;
        return year <= 1918 || year % 100 != 0 || year % 400 == 0;
    }

    private static void Main()
    {
        var year = Convert.ToInt32(Console.ReadLine());
        var result = Solve(year);
        Console.WriteLine(result);
    }
}