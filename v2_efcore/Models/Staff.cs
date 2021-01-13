using System;
using System.ComponentModel.DataAnnotations;

namespace v2_efcore.Models
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        
        [Required]
        [MaxLength(16)]
        public string Password { get; set; }
        
        public DateTime Birthday { get; set; }
        
        public bool Enabled { get; set; }
    }
}