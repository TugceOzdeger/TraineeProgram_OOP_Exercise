using System;

namespace TraineeProgram_OOP_Exercise
{
    class Risk : Calculation
    {   
        public Risk(decimal x, decimal y) : base (x, y)
        {
            risk1 = x;
            risk2 = y;
        }

        public override decimal Calculate()
        {
            Console.WriteLine("Calculated risk is: ");
            return risk1 * risk2 * riskFactor;
        }
    }
}
