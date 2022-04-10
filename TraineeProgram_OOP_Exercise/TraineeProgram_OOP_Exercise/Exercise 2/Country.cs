namespace TraineeProgram_OOP_Exercise
{
    internal class Country
    {
        private CountryEnum _countryCode { get; set; }

        public CountryEnum CountryCode
        {
            get => _countryCode;
            internal set { _countryCode = value; }
        }

       
    }
}