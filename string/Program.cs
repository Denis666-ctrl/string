using System;

class String
{
    static void Main()
    {
        string str1 = "Привет, Денис!";
        string str2 = "Привет, Денис!";
        string str3 = "Hello!";
        string substring = "Язык программирования";

        int compareResult = string.Compare(str1, str3);
        Console.WriteLine($"Compare(str1, str3): {compareResult} (0 - равны, <0 - меньше, >0 - больше)");

        bool areEqual = str1.Equals(str2);
        Console.WriteLine($"Equals(str1, str2): {areEqual}");

        int compareOrdinalResult = string.CompareOrdinal(str1, str3);
        Console.WriteLine($"CompareOrdinal(str1, str3): {compareOrdinalResult} (0 - равны, <0 - меньше, >0 - больше)");

        int index = str1.IndexOf(substring);
        Console.WriteLine($"IndexOf(\"{substring}\") в str1: {index}");

        bool containsSubstring = str1.Contains(substring);
        Console.WriteLine($"Contains(\"{substring}\") в str1: {containsSubstring}");

        bool areEqualOperator = str1 == str2;
        Console.WriteLine($"str1 == str2: {areEqualOperator}");

        bool areNotEqual = str1 != str3;
        Console.WriteLine($"str1 != str3: {areNotEqual}");
    }
}