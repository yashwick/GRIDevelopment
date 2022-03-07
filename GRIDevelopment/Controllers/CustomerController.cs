using Microsoft.AspNetCore.Mvc;

namespace GRIDevelopment.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
