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

        public Task<IEnumerable<Product>> GetLowStockProducts(int threshold)
        {
            return _reportRepository.GetLowStockProductsAsync(threshold);
        }
    }
}
