namespace AdventOfCode2025;

internal static class Program
{
    private static string[] TestInput => 
        """
        987654321111111
        811111111111119
        234234234234278
        818181911112111
        """
            .Split("\n");
    private static readonly string[] RealInput = InputLoader.Load(3, separator: "\n");

    private static void Main(string[] args)
    {
        Day3.Part1(RealInput);
        Day3.Part2(RealInput); 
    }
}