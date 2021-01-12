using System;
using System.ComponentModel.DataAnnotations;

namespace v2_efcore.Models
{
    public class Customer
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
        
        public DateTime Birthday { get; set; }
        
        //public Adress Adress { get; set; }
        public bool Enabled { get; set; }
    }
}