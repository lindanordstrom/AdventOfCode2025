namespace AdventOfCode2025;

internal static class Program
{
    // L50 - 0 - 1
    // R150 - 50 - 2
    // L50 - 0 - 3
    private static string[] TestInput => 
        """
        R50
        R150
        R50
        """
            .Split("\n");
    private static readonly string[] RealInput = InputLoader.Load(1, separator: "\n");

    private static void Main(string[] args)
    {
        Day1.Part1(RealInput);
        Day1.Part2(RealInput); 
    }
}