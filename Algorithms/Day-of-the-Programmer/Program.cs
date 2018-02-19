using System;
class Solution {

    static string Solve(int year)
    {
        return DateTime.IsLeapYear(year) ? 
            new DateTime(year, 1, 1).AddDays(256 - 1).ToString("dd.MM.yyyy") : 
            new DateTime(year, 1, 1).AddDays(256 - 2).ToString("dd.MM.yyyy");
    }

    static void Main() {
        int year = Convert.ToInt32(Console.ReadLine());
        string result = Solve(year);
            
        Console.WriteLine(result);
    }
}