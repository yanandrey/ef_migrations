using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace v2_efcore.Models
{
    public class Hiring
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("Staff")]
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        
        public DateTime Beginning { get; set; }
        
        [Required]
        [MaxLength(25)]
        public string Department { get; set; }
        
        [Required]
        [MaxLength(25)]
        public string Function { get; set; }
        
        public int Salary { get; set; }
        
        public bool Enabled { get; set; }
    }
}