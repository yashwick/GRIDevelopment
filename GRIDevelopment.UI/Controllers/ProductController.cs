﻿using GRIDevelopment.BL.Interface;
using GRIDevelopment.Contract.DTO;
using GRIDevelopment.Mpper;
using Microsoft.AspNetCore.Mvc;

namespace GRIDevelopment.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService, DomainProDTOMapper mapper)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAllProducts();
            return View(products);
        }


        [HttpGet]
        public IActionResult AddEditProduct(int? id)
        {
            if (id == null)
                return View();
            else
            {
                var product = _productService.GetProductById(id.Value);
                return View(product);
            }
        }

        [HttpPost]
        public IActionResult AddEditProduct(ProductDTO product)
        {
            if (!ModelState.IsValid)
                return View();

            if (product.Id > 0)
            {
                _productService.UpdatePost(product);
            }
            else
            {
                _productService.AddProduct(product);
            }

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Remove(int id)
        {
            _productService.RemovePost(id);

            return RedirectToAction("Index");
        }
        
    }
}
