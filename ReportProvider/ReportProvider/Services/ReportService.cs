using ReportProvider.DTO;
using ReportProvider.Models;

namespace ReportProvider.Services
{
    public class ReportService
    {
        private readonly IReportRepository _reportRepository;

        public ReportService(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        public Task<IEnumerable<Product>> GetMostSoldProducts()
        {
            return _reportRepository.GetMostSoldProductsAsync();
        }

        public Task<decimal> GetTotalRevenue()
        {
            return _reportRepository.GetTotalRevenueAsync();
        }

        public Task<IEnumerable<Product>> GetLowStockProducts()
        {
            return _reportRepository.GetLowStockProductsAsync();
        }
        public Task<IEnumerable<Inventory>> GetInventory()
        {
            return _reportRepository.GetInventoryAsync();
        }
        public Task<List<CustomerPurchaseStatisticsDto>> GetCustomerPurchaseStatisticsAsync()
        {
            return _reportRepository.GetCustomerPurchaseStatisticsAsync();
        }
    }
}
