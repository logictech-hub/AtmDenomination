namespace AtmDenominationSolver.Models
{
    public class Combination
    {
        public int Ten { get; set; }
        public int Fifty { get; set; }
        public int Hundred { get; set; }

        public override string ToString()
        {
            return $"{Ten} x 10 EUR, {Fifty} x 50 EUR, {Hundred} x 100 EUR";
        }
    }
}
