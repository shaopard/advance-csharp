// ------------------------------------------------------------------------------
//     <copyright file="Category.cs" company="BlackLine">
//         Copyright (C) BlackLine. All rights reserved.
//     </copyright>
// ------------------------------------------------------------------------------

using Abc.Core.Entities;

namespace Abc.Northwind.Entities.ConcreteTypes
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}