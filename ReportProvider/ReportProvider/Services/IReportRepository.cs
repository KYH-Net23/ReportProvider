using ReportProvider.Models;

namespace ReportProvider.Services
{
    public interface IReportRepository
    {
        Task<IEnumerable<Product>> GetMostSoldProductsAsync();
        Task<decimal> GetTotalRevenueAsync();
        Task<IEnumerable<Product>> GetLowStockProductsAsync(int threshold);
    }
}
