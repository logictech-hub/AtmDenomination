using System;
using AtmDenominationSolver.Services;

class Program
{
    static void Main()
    {
        var solver = new DenominationSolver();
        int[] amounts = { 30, 50, 60, 80, 140, 230, 370, 610, 980 };

        foreach (var amount in amounts)
        {
            Console.WriteLine($"\nCombinations for {amount} EUR:");
            var combinations = solver.GetCombinations(amount);
            if (combinations.Count == 0)
            {
                Console.WriteLine("  No valid combination.");
            }
            foreach (var combo in combinations)
            {
                Console.WriteLine($"  {combo}");
            }
        }
    }
}
