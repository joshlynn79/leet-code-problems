using LeetCode.Problems;
using LeetCode.Problems.Easy.RomanToInteger;

namespace LeetCode.App;

public static class MenuItems
{
    public static readonly Dictionary<int, (string DisplayName, ILeetCodeSolution Solution)> ProblemSolutions = new()
    {
        { 13, ("Roman to Integer", new RomanToInteger()) }
    };
}
