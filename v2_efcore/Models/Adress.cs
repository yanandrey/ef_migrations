using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace v2_efcore.Models
{
    public class Adress
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        
        [Required]
        [MaxLength(25)]
        public string StreetName { get; set; }
        
        public int HouseNumber { get; set; }
        
        public int ZipCode { get; set; }
        
        [Required]
        [MaxLength(25)]
        public string City { get; set; }
        
        [Required]
        [MaxLength(25)]
        public string Country {get; set; }
    }
}