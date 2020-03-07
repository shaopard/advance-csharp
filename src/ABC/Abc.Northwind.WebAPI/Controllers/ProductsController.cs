using System.Collections.Generic;
using System.Web.Http;

using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Entities.ConcreteTypes;

namespace Abc.Northwind.WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductService c_productService;

        public ProductsController(IProductService productService)
        {
            c_productService = productService;
        }

        public List<Product> Get()
        {
            List<Product> products = c_productService.GetAll();

            return products;
        }
    }
}