using Xunit;
using AtmDenominationSolver.Services;

namespace AtmDenominationSolver.Tests
{
    public class DenominationSolverTests
    {
        private readonly DenominationSolver _solver = new DenominationSolver();

        [Theory]
        [InlineData(30, 1)]
        [InlineData(50, 2)] // 1x50 OR 5x10
        [InlineData(100, 4)] // 10x10, 2x50, 1x100
        [InlineData(140, 4)] // multiple combinations
        [InlineData(25, 0)] // should be invalid
        public void Should_Calculate_Correct_Number_Of_Combinations(int amount, int expectedCount)
        {
            var combinations = _solver.GetCombinations(amount);
            Assert.Equal(expectedCount, combinations.Count);
        }

        [Fact]
        public void Should_Handle_Zero_Amount()
        {
            var result = _solver.GetCombinations(0);
            Assert.Single(result);
            Assert.Equal(0, result[0].Ten + result[0].Fifty + result[0].Hundred);
        }

        [Fact]
        public void Should_Return_Empty_When_Negative_Amount()
        {
            var result = _solver.GetCombinations(-50);
            Assert.Empty(result);
        }
    }
}
