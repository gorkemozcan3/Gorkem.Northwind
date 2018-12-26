using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gorkem.Northwind.Business.Abstract;
using Gorkem.Northwind.Entities.Concrete;
using Gorkem.Northwind.MvcWebUI.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Gorkem.Northwind.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;
        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }
        public ActionResult AddToCart(int productId)
        {
            Product product = _productService.GetById(productId);

            Cart cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, product);

            _cartSessionService.SetCart(cart);

            TempData.Add("message", String.Format("Ürün , {0}, sepete eklendi...", product.ProductName));

            return RedirectToAction("Index", "Product");
        }
    }
}