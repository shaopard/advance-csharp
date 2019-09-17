// ------------------------------------------------------------------------------
//     <copyright file="ProductManager.cs" company="BlackLine">
//         Copyright (C) BlackLine. All rights reserved.
//     </copyright>
// ------------------------------------------------------------------------------

using System.Collections.Generic;

using Abc.Core.CrossCuttingConcerns.Validation.Fluent;
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

        public void Add(Product product)
        {
            // AOP
            ValidationTool.FluentValidate(new ProductValidator() , product);

            // Business Rules
            c_productDal.Add(product);
        }

        public void Delete(Product product)
        {
            c_productDal.Delete(product);
        }

        public void Update(Product product)
        {
            c_productDal.Update(product);
        }
    }
}