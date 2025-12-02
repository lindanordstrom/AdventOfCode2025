using System.Numerics;

namespace AdventOfCode2025;

public static class Day2
{
    public static void Part1(string[] input)
    {
        Console.WriteLine(CountInvalidIDs(input, false));
    }

    public static void Part2(string[] input) {
        Console.WriteLine(CountInvalidIDs(input, true));
    }

    private static BigInteger CountInvalidIDs(string[] input, bool checkMoreThanTwo)
    {
        BigInteger sum = 0;
        foreach (var range in input)
        {
            var rangeParts = range.Split('-').Select(BigInteger.Parse).ToList();
            for (var i = rangeParts.First(); i <= rangeParts.Last(); i++)
            {
                var numberString = i.ToString();
                var maxPartsToCheck = checkMoreThanTwo ? numberString.Length : 2;
                
                for (var j = 2; j <= maxPartsToCheck; j++)
                {
                    if (!ContainsRepeatingParts(numberString, j)) continue;
                    sum += i;
                    break;
                }
            }
        }
        return sum;
    }
    
    private static bool ContainsRepeatingParts(string numberString, int numberOfParts)
    {
        if (numberString.Length % numberOfParts != 0) return false;
        var parts = new List<string>();
        var partLength = numberString.Length / numberOfParts;
        for (var i = 0; i < numberOfParts; i++)
        {
            var part = numberString.Substring(i * partLength, partLength);
            parts.Add(part);
        }
        return parts.Distinct().Count() == 1;
    }
}