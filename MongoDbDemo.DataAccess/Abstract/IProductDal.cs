using MongoDbDemo.Core.DataAccess;
using MongoDbDemo.Entities.Concrete;

namespace MongoDbDemo.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
