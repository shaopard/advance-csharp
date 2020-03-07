using System;

using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Business.Concrete;
using Abc.Northwind.DAL.Concrete.EntityFramework;
using Abc.Northwind.Entities.ConcreteTypes;

namespace Abc.Northwind.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new EfProductDal());

            foreach (Product product in productService.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            Console.ReadLine();
        }
    }
}