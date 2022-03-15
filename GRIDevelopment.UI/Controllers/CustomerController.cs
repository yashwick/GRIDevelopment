using GRIDevelopment.BL.Interface;
using GRIDevelopment.Contract.DTO;
using GRIDevelopment.Mpper;
using Microsoft.AspNetCore.Mvc;

namespace GRIDevelopment.UI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService, DomainCusDTOMapper mapper)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            var customers = _customerService.GetAllCustomers();
            return View(customers);
        }


        [HttpGet]
        public IActionResult AddEditCustomer(int? id)
        {
            if (id == null)
                return View();
            else
            {
                var customer = _customerService.GetCustomerById(id.Value);
                return View(customer);
            }
        }

        [HttpPost]
        public IActionResult AddEditCustomer(CustomerDTO customer)
        {
            if (!ModelState.IsValid)
                return View();

            if (customer.Id > 0)
            {
                _customerService.UpdatePost(customer);
            }
            else
            {
                _customerService.AddCustomer(customer);
            }

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Remove(int id)
        {
            _customerService.RemovePost(id);

            return RedirectToAction("Index");
        }

    }
}
