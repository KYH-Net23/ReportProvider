using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> GetMostSoldProducts(DateTime startDate, DateTime endDate)
        {
            var products = await _reportService.GetMostSoldProducts(startDate, endDate);
            return Ok(products);
        }

        [HttpGet("total-revenue")]
        public async Task<IActionResult> GetTotalRevenue(DateTime startDate, DateTime endDate)
        {
            var revenue = await _reportService.GetTotalRevenue(startDate, endDate);
            return Ok(new { revenue });
        }

        [HttpGet("low-stock-products")]
        public async Task<IActionResult> GetLowStockProducts(int threshold)
        {
            var products = await _reportService.GetLowStockProducts(threshold);
            return Ok(products);
        }
    }
}
