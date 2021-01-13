using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace v2_efcore.Models
{
    public class Rent
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        
        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        
        public int Duration { get; set; }
        
        public DateTime? CarReturn { get; set; }
    }
}