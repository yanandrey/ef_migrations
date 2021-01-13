using System.ComponentModel.DataAnnotations;

namespace v2_efcore.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(25)]
        public string Model { get; set; }
        
        public int Year { get; set; }
        
        [Required]
        [MaxLength(25)]
        public string Plate { get; set; }
        
        [Required]
        [MaxLength(25)]
        public string Color { get; set; }
        
        public bool Enabled { get; set; }
    }
}