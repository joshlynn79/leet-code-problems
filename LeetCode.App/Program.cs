using LeetCode.App;

Console.WriteLine("========================================");
Console.WriteLine("Welcome to the LeetCode problem solver!");
Console.WriteLine("========================================\n");

while (true)
{
    Console.WriteLine("Available problems:");
    Console.WriteLine("----------------------------------------");
    foreach (var problem in MenuItems.ProblemSolutions) Console.WriteLine($"{problem.Key}: {problem.Value.DisplayName}");
    Console.WriteLine("----------------------------------------\n");
    Console.Write("Select a LeetCode problem number or type 'Q' to quit: ");

    var input = Console.ReadLine();

    if (input?.ToUpper() == "Q") break;

    if (int.TryParse(input, out var problemNumber) && MenuItems.ProblemSolutions.TryGetValue(problemNumber, out var solutionTuple))
    {
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine($"Executing: {solutionTuple.DisplayName}\n");

        solutionTuple.Solution.Execute();
    }
    else
    {
        Console.WriteLine("Invalid selection. Please try again.\n");
    }
}
