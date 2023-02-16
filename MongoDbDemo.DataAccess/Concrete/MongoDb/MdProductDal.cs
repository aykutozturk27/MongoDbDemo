using MongoDbDemo.Core.DataAccess.MongoDb;
using MongoDbDemo.DataAccess.Abstract;
using MongoDbDemo.Entities.Concrete;

namespace MongoDbDemo.DataAccess.Concrete.MongoDb
{
    public class MdProductDal : MdEntityRepositoryBase<Product>, IProductDal
    {
    }
}
