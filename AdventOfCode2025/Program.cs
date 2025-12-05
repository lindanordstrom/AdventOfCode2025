namespace AdventOfCode2025;

internal static class Program
{
    private static string[] TestInput => 
        """
        3-5
        10-14
        16-20
        12-18
        
        1
        5
        8
        11
        17
        32
        """
            .Split("\n\n");
    private static readonly string[] RealInput = InputLoader.Load(5, separator: "\n\n");

    private static void Main(string[] args)
    {
        Day5.Part1(RealInput); 
        Day5.Part2(RealInput); 
    }
}