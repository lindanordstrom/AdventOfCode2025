using System.Numerics;
namespace AdventOfCode2025;

public static class Day4
{
    public static void Part1(string[] input) 
    {
        Console.WriteLine(CountRolls(input, false));
    }

    public static void Part2(string[] input) 
    {
        Console.WriteLine(CountRolls(input, true));
    } 
    
    private static BigInteger CountRolls(string[] input, bool tryAgainAfterRemoval)
    {
        BigInteger sum = 0;
        var run = true;

        while (run)
        {
            var removedAny = false;
            
            for (var i = 0; i < input.Length; i++)
            {
                for (var j = 0; j < input[i].Length; j++)
                {
                    var adjacentRolls = 0;
                    if (input[i][j] != '@') continue;

                    var rowRange = (Math.Max(0, i - 1), Math.Min(input.Length - 1, i + 1));
                    var colRange = (Math.Max(0, j - 1), Math.Min(input[i].Length - 1, j + 1));
                    for (var column = colRange.Item1; column <= colRange.Item2; column++)
                    {
                        for (var row = rowRange.Item1; row <= rowRange.Item2; row++)
                        {
                            if (input[row][column] == '@')
                                adjacentRolls++;
                        }
                    }

                    if (adjacentRolls < 5)
                    {
                        sum++;
                        if (tryAgainAfterRemoval)
                        {
                            removedAny = true;
                            input[i] = input[i].Remove(j, 1).Insert(j, ".");
                        }
                    }
                }
            }
            run = removedAny;
        }
        return sum;
    }
}