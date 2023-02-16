using MongoDbDemo.Entities.Concrete;

namespace MongoDbDemo.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product Add(Product product);
    }
}
