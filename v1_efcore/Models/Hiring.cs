using System;

namespace v1_efcore.Models
{
    public class Hiring
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public DateTime Beginning { get; set; }
        public string Department { get; set; }
        public string Function { get; set; }
        public int Salary { get; set; }
        public bool Enabled { get; set; }
    }
}