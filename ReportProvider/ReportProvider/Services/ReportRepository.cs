using ReportProvider.Data;
using ReportProvider.Models;
using Microsoft.EntityFrameworkCore;

namespace ReportProvider.Services
{
    public class ReportRepository : IReportRepository
    {
        private readonly AppDbContext _context;

        public ReportRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetMostSoldProductsAsync()
        {
            return await _context.OrderDetails
                .GroupBy(od => od.Product)
                .OrderByDescending(g => g.Sum(od => od.Quantity))
                .Select(g => g.Key)
                .ToListAsync();
        }

        public async Task<decimal> GetTotalRevenueAsync()
        {
            return await _context.OrderDetails
                .SumAsync(od => od.Quantity * od.Price);
        }

        public async Task<IEnumerable<Product>> GetLowStockProductsAsync(int threshold)
        {
            return await _context.Products
                .Where(p => p.Stock <= threshold)
                .ToListAsync();
        }
    }
}
