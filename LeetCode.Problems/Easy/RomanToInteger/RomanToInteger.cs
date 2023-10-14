using System.Text.RegularExpressions;

namespace LeetCode.Problems.Easy.RomanToInteger;

public partial class RomanToInteger : ILeetCodeSolution
{
    private static readonly Dictionary<char, int> RomanToValue = new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    public void Execute()
    {
        Console.Clear();

        Console.WriteLine("Welcome to the RomanToInteger problem!\n");

        while (true)
        {
            var romanNumeral = PromptForRomanNumeral();

            if (romanNumeral == "Q")
            {
                Console.WriteLine("Exiting RomanToInteger problem...\n");
                break;
            }

            var result = Solution(romanNumeral);

            DisplayResult(romanNumeral, result);
        }
    }

    private static int Solution(string value)
    {
        var total = 0;

        for (var i = 0; i < value.Length; i++)
        {
            var currentRomanCharacter = value[i];
            var currentValue = RomanToValue[currentRomanCharacter];

            if (i + 1 < value.Length)
            {
                var nextRomanCharacter = value[i + 1];
                var nextValue = RomanToValue[nextRomanCharacter];

                if (currentValue < nextValue)
                {
                    total += nextValue - currentValue;
                    i++; // Skip the next character since we've processed it
                }
                else
                {
                    total += currentValue;
                }
            }
            else
            {
                total += currentValue;
            }
        }

        return total;
    }

    private static void DisplayResult(string romanNumeral, int result)
    {
        Console.WriteLine($"\nRoman numeral: {romanNumeral}");
        Console.WriteLine($"Integer value: {result}\n");
    }

    private static string PromptForRomanNumeral()
    {
        Console.Write("Enter a Roman numeral or 'Q' to quit: ");
        while (true)
        {
            var input = Console.ReadLine() ?? string.Empty;

            input = input.ToUpper();

            if (input == "Q" || IsValidRomanNumeral(input)) return input;

            Console.Write("Invalid Roman numeral. Please try again or type 'Q' to quit: ");
        }
    }

    private static bool IsValidRomanNumeral(string? input)
    {
        if (string.IsNullOrEmpty(input)) return false;

        var regex = RomanRegex();

        return regex.IsMatch(input);
    }

    [GeneratedRegex("^(M{0,3})(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$")]
    private static partial Regex RomanRegex();
}
