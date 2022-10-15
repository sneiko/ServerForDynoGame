using GameServer.Models.Entities;
using GameServer.Models.MongoDB.Entities;
using GameServer.Models.Repositories;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace GameServer.Models.MongoDB.Repositories;

public abstract class MongoDbRepository<TEntity, TEntityImpl> : IMongoDbRepository<TEntity>
    where TEntityImpl : BaseEntity
    where TEntity : IBaseEntity
{
    private MongoUrl _mongoUrl { get; }
    private string _collectionName { get; }

    protected MongoDbRepository(string connectionString, string collectionName)
    {
        _mongoUrl = new MongoUrl(connectionString);
        _collectionName = collectionName;
    }

    public virtual async Task<TEntity> GetByIdAsync(string id, CancellationToken cancellationToken)
    {
        var client = new MongoClient(_mongoUrl)
            .GetDatabase(_mongoUrl.DatabaseName)
            .GetCollection<TEntity>(_collectionName)
            .AsQueryable();

        return await client
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync(cancellationToken);
    }

    public virtual async Task Insert(TEntity entity, CancellationToken cancellationToken)
    {
        var client = new MongoClient(_mongoUrl)
            .GetDatabase(_mongoUrl.DatabaseName)
            .GetCollection<TEntity>(_collectionName);

        await client.InsertOneAsync(entity, new InsertOneOptions(), cancellationToken);
    }

    protected abstract void MapToEntity(TEntityImpl entityImpl, TEntity entity);
}