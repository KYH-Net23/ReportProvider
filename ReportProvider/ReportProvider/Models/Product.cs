namespace ReportProvider.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = null!;
    }
}
