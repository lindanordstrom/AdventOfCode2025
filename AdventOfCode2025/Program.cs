namespace AdventOfCode2025;

internal static class Program
{
    private static string[] TestInput => 
        """
        11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124
        """
            .Split(",");
    private static readonly string[] RealInput = InputLoader.Load(2, separator: ",");

    private static void Main(string[] args)
    {
        Day2.Part1(RealInput);
        Day2.Part2(RealInput); 
    }
}