using System;
using TraineeProgram_OOP_Exercise.Exercise_2;

namespace TraineeProgram_OOP_Exercise
{
    class Tax : ICalculation
    {
        private readonly decimal tax1;
        private readonly decimal tax2;
        private readonly Country country;
        public decimal taxFactor;

        public Tax(decimal x, decimal y, Country country)
        {
            tax1 = x;
            tax2 = y;
            this.country = country;
        }

        private void returnTaxFactor()
        {
            if (this.country.CountryCode == CountryEnum.Sweden)
                taxFactor = -1;
        }


        public decimal Calculate()
        {
            returnTaxFactor();
            Console.WriteLine("Calculated tax is: ");
            return tax1 * tax2 * taxFactor;
        }
    }
}
