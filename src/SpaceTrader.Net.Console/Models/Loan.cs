using System;

namespace SpaceTrader.Net.Models
{
    public class UserLoan
    {
        public string Id { get; set; }
        public DateTime Due { get; set; }
        public int RepaymentAmount { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
    }
}