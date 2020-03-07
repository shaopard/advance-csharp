using Abc.Core.Entities;

namespace Abc.Northwind.Entities.ConcreteTypes
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}