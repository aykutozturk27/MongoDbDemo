using MongoDbDemo.Business.Abstract;
using MongoDbDemo.Business.DependencyResolvers.Ninject;
using MongoDbDemo.Entities.Concrete;

var productService = InstanceFactory.GetInstance<IProductService>();
//var product = new Product
//{
//    ProductName = "test product",
//    QuantityPerUnit = "test quantity",
//    UnitPrice = 1000,
//    UnitsInStock = 1
//};
//var addedProduct = productService.Add(product);
var productList = productService.GetAll();
Console.ReadLine();
#region OldCode
//var connectionString = CoreConfig.GetValue("MongoDb:Host");
//var client = new MongoClient(connectionString);
//var database = client.GetDatabase("test");
//var collection = database.GetCollection<BsonDocument>("people");
//var document = new BsonDocument
//{
//    { "Name" , "test" },
//    { "Age" , 33 }
//};
//await collection.InsertOneAsync(document); 
#endregion
