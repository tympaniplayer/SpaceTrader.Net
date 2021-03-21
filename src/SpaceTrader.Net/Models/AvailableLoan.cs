namespace SpaceTrader.Net.Models
{
    public class AvailableLoan
    {
        public string Type { get; set; }
        public int Amount { get; set; }
        public bool CollateralRequired { get; set; }
        public double Rate { get; set; }
        public int TermInDays { get; set; }
    }
}