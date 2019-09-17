// ------------------------------------------------------------------------------
//     <copyright file="NhProductDal.cs" company="BlackLine">
//         Copyright (C) BlackLine. All rights reserved.
//     </copyright>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using Abc.Northwind.DAL.Abstract;
using Abc.Northwind.Entities.ConcreteTypes;

namespace Abc.Northwind.DAL.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public List<Product> GetList(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Product Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}