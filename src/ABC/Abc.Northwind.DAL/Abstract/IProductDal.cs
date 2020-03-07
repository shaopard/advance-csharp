using Abc.Core.DataAccess;
using Abc.Northwind.Entities.ConcreteTypes;

namespace Abc.Northwind.DAL.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        //special methods related to product
    }
}