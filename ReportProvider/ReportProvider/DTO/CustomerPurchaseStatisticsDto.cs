namespace ReportProvider.DTO
{
    public class CustomerPurchaseStatisticsDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int TotalOrders { get; set; }
        public decimal TotalSpent { get; set; }
        public int TotalProductsPurchased { get; set; }
    }
}
