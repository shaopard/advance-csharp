// ------------------------------------------------------------------------------
//     <copyright file="ProductController.cs" company="BlackLine">
//         Copyright (C) BlackLine. All rights reserved.
//     </copyright>
// ------------------------------------------------------------------------------

using System.Web.Mvc;

using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Entities.ConcreteTypes;
using Abc.Northwind.MvcWebUI.Models;

namespace Abc.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService c_productService;

        public ProductController(IProductService productService)
        {
            c_productService = productService;
        }

        // GET: Product
        public ActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products = c_productService.GetAll()
            };

            return View(model);
        }

        public string Add()
        {
            var newProduct = new Product
            {
                ProductName = string.Empty
            };

            c_productService.Add(newProduct);

            return "Added";
        }
    }
}