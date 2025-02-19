using System;
using System.Collections.Generic;

class ConvertSetToList
{
    static List<int> ConvertAndSort(HashSet<int> set)
    {
        List<int> sortedList = new List<int>(set); // Convert HashSet to List
        sortedList.Sort(); // Sort in ascending order
        return sortedList;
    }

    static void Main(string[] args)
    {
        HashSet<int> numbers = new HashSet<int> { 5, 3, 9, 1 };
        List<int> sortedNumbers = ConvertAndSort(numbers);

        Console.WriteLine(string.Join(", ", sortedNumbers)); // Output: 1, 3, 5, 9
    }
}