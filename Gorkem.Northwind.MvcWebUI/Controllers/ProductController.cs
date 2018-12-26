using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gorkem.Northwind.Business.Abstract;
using Gorkem.Northwind.Entities.Concrete;
using Gorkem.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gorkem.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int page = 1, int category = 0) // paging için parametre eklendi (query string)
        {
            int pageSize = 10; // sayfada görünecek eleman sayısı
            //var products = _productService.GetAll();
            var products = _productService.GetByCategory(category);
            ProductListViewModel model = new ProductListViewModel()
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(products.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = category,
                CurrentPage = page
            };
            return View(model);
        }


        
    }
}