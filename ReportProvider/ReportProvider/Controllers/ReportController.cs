using Microsoft.AspNetCore.Mvc;
using ReportProvider.DTO;
using ReportProvider.Services;

namespace ReportProvider.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly ReportService _reportService;

        public ReportController(ReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("most-sold-products")]
        public async Task<IActionResult> GetMostSoldProducts()
        {
            var products = await _reportService.GetMostSoldProducts();
            return Ok(products);
        }

        [HttpGet("total-revenue")]
        public async Task<IActionResult> GetTotalRevenue()
        {
            var revenue = await _reportService.GetTotalRevenue();
            return Ok(new { revenue }); 
        }

        [HttpGet("low-stock-products")]
        public async Task<IActionResult> GetLowStockProducts()
        {
            var products = await _reportService.GetLowStockProducts();
            return Ok(products);
        }
        [HttpGet("customer-purchase-statistics")]
        public async Task<ActionResult<List<CustomerPurchaseStatisticsDto>>> GetCustomerPurchaseStatistics()
        {
            var statistics = await _reportService.GetCustomerPurchaseStatisticsAsync();
            return Ok(statistics);
        }
        [HttpGet("inventory")]
        public async Task<IActionResult> GetInventory()
        {
            var inventory = await _reportService.GetInventory();
            return Ok(inventory);
        }
    }
}
