﻿namespace ReportProvider.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    }
}
