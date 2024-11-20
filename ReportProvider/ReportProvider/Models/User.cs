﻿namespace ReportProvider.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public ICollection<Order> Orders { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = null!;
    }
}