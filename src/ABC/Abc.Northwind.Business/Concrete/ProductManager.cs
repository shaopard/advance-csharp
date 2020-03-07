using System.Collections.Generic;

using Abc.Core.Aspects.Postsharp.ValidationAspects;
using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Business.ValidationRules.FluentValidation;
using Abc.Northwind.DAL.Abstract;
using Abc.Northwind.Entities.ConcreteTypes;

namespace Abc.Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal c_productDal;

        public ProductManager(IProductDal productDal)
        {
            c_productDal = productDal;
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public void Add(Product product)
        {
            // Business Rules
            c_productDal.Add(product);
        }

        public void Delete(Product product)
        {
            c_productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            List<Product> products = c_productDal.GetList();
            return products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            List<Product> products = c_productDal.GetList(p => p.CategoryId == categoryId);
            return products;
        }

        public void Update(Product product)
        {
            c_productDal.Update(product);
        }
    }
}