using ReportProvider.Data;
using ReportProvider.Models;
using Microsoft.EntityFrameworkCore;
using ReportProvider.DTO;

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

        public async Task<IEnumerable<Product>> GetLowStockProductsAsync()
        {
            return await _context.Products
                .Where(p => p.Stock <= 100)
                .ToListAsync();
        }
        public async Task<List<CustomerPurchaseStatisticsDto>> GetCustomerPurchaseStatisticsAsync()
        {
            var statistics = await _context.Users
                .Select(user => new CustomerPurchaseStatisticsDto
                {
                    UserId = user.Id,
                    UserName = user.Name,
                    TotalOrders = user.Orders.Count,
                    TotalSpent = user.Orders
                        .SelectMany(order => order.OrderDetails)
                        .Sum(detail => detail.Quantity * detail.Price),
                    TotalProductsPurchased = user.Orders
                        .SelectMany(order => order.OrderDetails)
                        .Sum(detail => detail.Quantity)
                })
                .ToListAsync();

            return statistics;
        }
        public async Task<IEnumerable<Inventory>> GetInventoryAsync()
        {
            return await _context.Inventory
                .ToListAsync();
        }
    }
}
