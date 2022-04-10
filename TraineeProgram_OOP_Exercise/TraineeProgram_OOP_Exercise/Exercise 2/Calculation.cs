namespace TraineeProgram_OOP_Exercise
{
    abstract class Calculation
    {
        public decimal risk1;
        public decimal risk2;
        public decimal riskFactor = decimal.MinusOne;

        public Calculation(decimal x, decimal y)
        {
            risk1 = x;
            risk2 = y;
        }

        public abstract decimal Calculate();
    }
}
