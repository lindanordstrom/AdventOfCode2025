using System.Numerics;
namespace AdventOfCode2025;

public static class Day3
{
    public static void Part1(string[] input) 
    {
        Console.WriteLine(GetJoltage(input, false));
    }

    public static void Part2(string[] input) 
    {
        Console.WriteLine(GetJoltage(input, true));
    }

    private static BigInteger GetJoltage(string[] input, bool moreIterations)
    {
        BigInteger sum = 0;
        foreach (var line in input)
        {
            var numbers = new List<IndexValue>();
            var iterations = moreIterations ? 12 : 2;
            for (var iteration = 0; iteration < iterations; iteration++)
            {
                numbers.Add(new IndexValue { Index = 0, Value = 0 });
                var index = iteration > 0 ? numbers[iteration - 1].Index + 1 : 0;
                for (var i = index; i < line.Length - iterations + iteration + 1; i++)
                {
                    var number = BigInteger.Parse(line[i].ToString());
                    if (number > numbers[iteration].Value)
                    {
                        numbers[iteration].Value = number;
                        numbers[iteration].Index = i;
                    }
                }
            }
            var joltageString = numbers.Aggregate("", (current, number) => current + number.Value);
            sum += BigInteger.Parse(joltageString);
        }

        return sum;
    }

    private class IndexValue
    { 
        public int Index { get; set; }
        public BigInteger Value { get; set; }
    }
}