// ------------------------------------------------------------------------------
//     <copyright file="ProductListViewModel.cs" company="BlackLine">
//         Copyright (C) BlackLine. All rights reserved.
//     </copyright>
// ------------------------------------------------------------------------------

using System.Collections.Generic;

using Abc.Northwind.Entities.ConcreteTypes;

namespace Abc.Northwind.MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
    }
}