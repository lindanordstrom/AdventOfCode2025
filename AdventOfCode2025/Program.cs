namespace AdventOfCode2025;

internal static class Program
{
    private static string[] TestInput => 
        """
        ..@@.@@@@.
        @@@.@.@.@@
        @@@@@.@.@@
        @.@@@@..@.
        @@.@@@@.@@
        .@@@@@@@.@
        .@.@.@.@@@
        @.@@@.@@@@
        .@@@@@@@@.
        @.@.@@@.@.
        """
            .Split("\n");
    private static readonly string[] RealInput = InputLoader.Load(4, separator: "\n");

    private static void Main(string[] args)
    {
        Day4.Part1(RealInput);
        Day4.Part2(RealInput); 
    }
}