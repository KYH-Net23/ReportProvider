using ReportProvider.Models;

namespace ReportProvider.Services
{
    public interface IReportRepository
    {
        Task<IEnumerable<Product>> GetMostSoldProductsAsync(DateTime startDate, DateTime endDate);
        Task<decimal> GetTotalRevenueAsync(DateTime startDate, DateTime endDate);
        Task<IEnumerable<Product>> GetLowStockProductsAsync(int threshold);
    }
}
