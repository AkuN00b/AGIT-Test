using AGIT_Test.Data;
using Microsoft.AspNetCore.Mvc;

namespace AGIT_Test.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly ApplicationDbContext _context;

        public DataController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public JsonResult GetRevenueByItemGroup()
        {
            var data = _context.RevenueByItemGroups.Select(r => new { r.ItemGroup, r.Revenue }).ToList();
            return new JsonResult(data);
        }

        [HttpGet]
        public JsonResult GetRevenueByCountry()
        {
            var data = _context.RevenueByCountries.Select(r => new { r.Country, r.Revenue }).ToList();
            return new JsonResult(data);
        }
    }
}
