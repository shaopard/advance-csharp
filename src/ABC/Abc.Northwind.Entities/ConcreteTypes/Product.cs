// ------------------------------------------------------------------------------
//     <copyright file="Product.cs" company="BlackLine">
//         Copyright (C) BlackLine. All rights reserved.
//     </copyright>
// ------------------------------------------------------------------------------

using Abc.Core.Entities;

namespace Abc.Northwind.Entities.ConcreteTypes
{
    public class Product : IEntity
    {
        public int CategoryId { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal UnitPrice { get; set; }

        public short UnitsInStock { get; set; }
    }
}