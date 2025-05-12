using System.Collections.Generic;
using AtmDenominationSolver.Models;

namespace AtmDenominationSolver.Services
{
    public class DenominationSolver
    {
        public List<Combination> GetCombinations(int amount)
        {
            var results = new List<Combination>();
            for (int h = 0; h <= amount / 100; h++)
            {
                for (int f = 0; f <= (amount - h * 100) / 50; f++)
                {
                    int remaining = amount - h * 100 - f * 50;
                    if (remaining % 10 == 0)
                    {
                        int t = remaining / 10;
                        results.Add(new Combination { Ten = t, Fifty = f, Hundred = h });
                    }
                }
            }
            return results;
        }
    }
}
