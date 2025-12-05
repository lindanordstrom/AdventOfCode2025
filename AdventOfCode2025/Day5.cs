using System.Numerics;
namespace AdventOfCode2025;

public static class Day5
{
    public static void Part1(string[] input) 
    {
        Console.WriteLine(X(input, false));
    }

    public static void Part2(string[] input) 
    {
        Console.WriteLine(X(input, true));
    } 
    
    private static BigInteger X(string[] input, bool all)
    {
        BigInteger sum = 0;
        
        var ranges = new List<(BigInteger start, BigInteger end)>();
        foreach (var line in input[0].Split("\n"))
        {
            var parts = line.Split("-");
            ranges.Add((BigInteger.Parse(parts[0]), BigInteger.Parse(parts[1])));
        }
        
        if (all)
        {
            BigInteger currentEnd = 0;
            ranges.Sort((a, b) => a.start.CompareTo(b.start));
            for (var i = 0; i < ranges.Count; i++)
            {
                var r = ranges[i];
                r.end++;
                sum += BigInteger.Max(currentEnd, r.end) - BigInteger.Max(currentEnd, r.start);
                currentEnd = BigInteger.Max(currentEnd, r.end);
            }
        }
        else
        {
            foreach (var line in input[1].Split("\n"))
                foreach (var r in ranges)
                    if (BigInteger.Parse(line) >= r.start && BigInteger.Parse(line) <= r.end)
                    {
                        sum++;
                        break;
                    }
        }
        return sum;
    }
}