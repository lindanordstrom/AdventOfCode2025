namespace AdventOfCode2025;

public static class Day1
{
    public static void Part1(string[] input)
    {
        Console.WriteLine(CountStopsAtZero(input, false));
    }

    public static void Part2(string[] input) {
        Console.WriteLine(CountStopsAtZero(input, true));
    }

    enum Direction { Left, Right }

    private static int CountStopsAtZero(string[] input, bool passingZeroCounts)
    {
        var dial = 50;
        var stopsAtZero = 0;

        foreach (var line in input)
        {
            var direction = line[0] == 'L' ? Direction.Left : Direction.Right;
            var amount = int.Parse(line[1..]);

            if (passingZeroCounts)
            {
                var negativeHandledDial = direction == Direction.Left && dial != 0 ? 100 - dial : dial;
                stopsAtZero += (negativeHandledDial + amount) / 100;
            }

            dial = UpdateDial(dial, amount, direction);

            if (!passingZeroCounts && dial == 0)
                stopsAtZero++;
        }

        return stopsAtZero;
    }

    private static int UpdateDial(int dial, int amount, Direction direction)
    {
        var lastTwoDigits = amount % 100;
        
        if (direction == Direction.Left)
            dial -= lastTwoDigits;
        else if (direction == Direction.Right)
            dial += lastTwoDigits;
        
        if (dial < 0)
            dial += 100;
        else if (dial > 99)
            dial -= 100;
        
        return dial;
    }
}