using GRIDevelopment.Data;
using GRIDevelopment.Models;
using Microsoft.AspNetCore.Mvc;

namespace GRIDevelopment.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> objCategoryList = _db.products.ToList();
            return View(objCategoryList);
        }
    }
}
