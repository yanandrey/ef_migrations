using System;

namespace v1_efcore.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public Adress Adress { get; set; }
        public bool Enabled { get; set; }
    }
}