namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string suiteType, int capacity, decimal pricePerDay)
        {
            SuiteType = suiteType;
            Capacity = capacity;
            PricePerDay = pricePerDay;
        }

        public string SuiteType { get; set; }
        public int Capacity { get; set; }
        public decimal PricePerDay { get; set; }
    }
}