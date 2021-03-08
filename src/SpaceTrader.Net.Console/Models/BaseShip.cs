namespace SpaceTrader.Net.Models
{
    public abstract class BaseShip
    {
        public string Type { get; set; }
        public string Class { get; set; }
        public int MaxCargo { get; set; }
        public int Speed { get; set; }
        public string Manufacturer { get; set; }
        public int Plating { get; set; }
        public int Weapons { get; set; }
    }
}