using GRIDevelopment.BL;
using GRIDevelopment.BL.Interface;
using GRIDevelopment.Contract.DTO;
using GRIDevelopment.DAL.DomainModel;
using GRIDevelopment.Mpper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GRIDevelopment.UI.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService, DomainDTOMapper mapper)
        {
            _supplierService = supplierService;
        }

        public IActionResult Index()
        {
            var suppliers = _supplierService.GetAllSuppliers();
            return View(suppliers);
        }

        //[HttpGet]
        //public IActionResult AddSupplier()
        //{
        //    return View();
        //}


        //[HttpPost]
        //public IActionResult AddSupplier(SupplierDTO supplier)
        //{
        //    _supplierService.AddSupplier(supplier);

        //    return View();
        //}


        [HttpGet]
        public IActionResult AddEditSupplier(int? id)
        {
            if (id == null)
                return View();
            else
            {
                var supplier = _supplierService.GetSupplierById(id.Value);
                return View(supplier);
            }
        }

        [HttpPost]
        public IActionResult AddEditSupplier(SupplierDTO supplier)
        {
            if (!ModelState.IsValid)
                return View();
            
                if (supplier.Id > 0)
                {
                    _supplierService.UpdatePost(supplier);
                }
                else
                {
                    _supplierService.AddSupplier(supplier);
                }
            
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Remove(int id)
        {
            _supplierService.RemovePost(id);

            return RedirectToAction("Index");
        }

    }
}
