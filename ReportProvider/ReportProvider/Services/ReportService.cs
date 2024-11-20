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

        public Task<IEnumerable<Product>> GetMostSoldProducts(DateTime startDate, DateTime endDate)
        {
            return _reportRepository.GetMostSoldProductsAsync(startDate, endDate);
        }

        public Task<decimal> GetTotalRevenue(DateTime startDate, DateTime endDate)
        {
            return _reportRepository.GetTotalRevenueAsync(startDate, endDate);
        }

        public Task<IEnumerable<Product>> GetLowStockProducts(int threshold)
        {
            return _reportRepository.GetLowStockProductsAsync(threshold);
        }
    }
}
