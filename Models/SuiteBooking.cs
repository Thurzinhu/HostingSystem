namespace DesafioProjetoHospedagem.Models
{
    public class SuiteBooking
    {
        public SuiteBooking() { }

        public SuiteBooking(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public List<Person> Hosts { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }
        public const int DaysForDiscount = 10;

        public void RegisterHosts(List<Person> hosts)
        {
            if (Suite.Capacity >= hosts.Count)
            {
                Hosts = hosts;
            }
            else
            {
                throw new Exception("Suite cannot handle this numver of hosts");
            }
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetTotalHosts()
        {
            return Hosts.Count;
        }

        public decimal GetTotalPrice()
        {
            decimal total = ReservedDays * Suite.PricePerDay;

            if (ReservedDays >= DaysForDiscount)
            {
                total -= ((decimal)0.1 * total);
            }

            return total;
        }
    }
}