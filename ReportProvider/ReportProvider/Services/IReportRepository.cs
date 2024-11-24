using ReportProvider.Models;
using ReportProvider.DTO;

namespace ReportProvider.Services
{
    public interface IReportRepository
    {
        Task<IEnumerable<Product>> GetMostSoldProductsAsync();
        Task<decimal> GetTotalRevenueAsync();
        Task<IEnumerable<Product>> GetLowStockProductsAsync();
        Task<IEnumerable<Inventory>> GetInventoryAsync();
        Task<List<CustomerPurchaseStatisticsDto>> GetCustomerPurchaseStatisticsAsync();
    }
}
