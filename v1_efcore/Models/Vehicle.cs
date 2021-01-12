namespace v1_efcore.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Plate { get; set; }
        public string Color { get; set; }
        public bool Enabled { get; set; }
    }
}