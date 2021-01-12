using System;

namespace v1_efcore.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public int Duration { get; set; }
        public DateTime? CarReturn { get; set; }
    }
}