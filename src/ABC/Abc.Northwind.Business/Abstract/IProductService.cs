// ------------------------------------------------------------------------------
//     <copyright file="IProductService.cs" company="BlackLine">
//         Copyright (C) BlackLine. All rights reserved.
//     </copyright>
// ------------------------------------------------------------------------------

using System.Collections.Generic;

using Abc.Northwind.Entities.ConcreteTypes;

namespace Abc.Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetAllByCategory(int categoryId);

        void Add(Product product);

        void Delete(Product product);

        void Update(Product product);
    }
}