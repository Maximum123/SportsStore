using SportStore.Domain.Abstracts;
using SportStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ActionResult List()
        {
            //_productRepository.Edit(new Product { Name = "Test", Category = "Waterpool", Description = "TestDEscr", Price = 125 });
            var products = _productRepository.Products;
            return View(products);
        }
    }
}