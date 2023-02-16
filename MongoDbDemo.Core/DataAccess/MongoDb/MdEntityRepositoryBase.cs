using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbDemo.Core.Entities;
using MongoDbDemo.Core.Utilities.Configuration;
using System.Linq.Expressions;

namespace MongoDbDemo.Core.DataAccess.MongoDb
{
    public class MdEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        private readonly string _connectionString;
        private readonly MongoClient _connection;
        private readonly IMongoCollection<TEntity> _collection;
        private readonly IMongoDatabase _database;
        private readonly string _collectionBaseName = "MongoDbDemo";
        private readonly string _entityName;

        public MdEntityRepositoryBase()
        {
            _connectionString = CoreConfig.GetValue("MongoDb:Host");
            _connection = new MongoClient(_connectionString);
            _database = _connection.GetDatabase(_collectionBaseName);
            _entityName = typeof(TEntity).Name;
            _collection = _database.GetCollection<TEntity>(_entityName);
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            //var list = _connection.ListDatabases().ToList();
            return filter == null 
                ? _collection.Find(_ => true).ToList()
                : _collection.Find(filter).ToList();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _collection.Find(filter).SingleOrDefault();
        }

        public TEntity Add(TEntity entity)
        {
            _collection.InsertOne(entity);
            //_collection.InsertOne(entity);
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            var document = new BsonDocument { };
            var update = Builders<BsonDocument>.Update.Set(typeof(TEntity).Name, entity);
            _collection.UpdateOne(null, document);
            return entity;
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
