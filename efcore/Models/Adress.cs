namespace efcore.Models
{
    public class Adress
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Country {get; set; }
    }
}