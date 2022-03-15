using Contract.DTO;
using Microsoft.AspNetCore.Mvc;
using BAL.Interfaces;
using Contract;
using Mapper;


namespace GRIDevelopment.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService, DomainCustomerMapper mapper)
        {
            _customerService = customerService;
        }

        //public IActionResult Index()
        //{
        //    var customers = _customerService.GetAllCustomers();
        //    return View(customers);
        //}
        [HttpGet]
        public IActionResult AddEditCustomer(int id)
        {
            if (id == 0)
                return View();
            else 
            {
                var customer = _customerService.GetCustomerById(id);
                return View(customer);
            }
        }
        //[HttpPost]
        //public IActionResult AddEditCustomer(CustomerDTO customer)
        //{
        //    //if(!ModelState.IsValid)
        //    //    return View();

        //    ////if (customer.Id > 0)
        //    ////{
        //    ////    _customerService.UpdateCustomer(customer);
        //    ////}
        //    ////else
        //    ////{
        //    ////    _customerService.AddCustomer(customer);
        //    ////}
        //    //return RedirectToAction("Index");
        //}

        [HttpGet]
        public IActionResult Remove(int id)
        {
            _customerService.RemovePost(id);
            return RedirectToAction("Index");
        }
    }
}
