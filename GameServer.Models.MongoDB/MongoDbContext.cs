using GameServer.Models.MongoDB.Entities;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace GameServer.Models.MongoDB;

public class MongoDbContext<T> where T : BaseEntity
{
    private MongoUrl _mongoUrl { get; init; }
    private string _collectionName { get; init; }

    public MongoDbContext(string connectionString, string collectionName)
    {
        _mongoUrl = new MongoUrl(connectionString);
        _collectionName = collectionName;
    }

    public async Task<T> GetByIdAsync(string id, CancellationToken cancellationToken)
    {
        var client = new MongoClient(_mongoUrl)
            .GetDatabase(_mongoUrl.DatabaseName)
            .GetCollection<T>(_collectionName)
            .AsQueryable();

        return await client
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync(cancellationToken);
    }

    public async Task Insert(T entity, CancellationToken cancellationToken)
    {
        var client = new MongoClient(_mongoUrl)
            .GetDatabase(_mongoUrl.DatabaseName)
            .GetCollection<T>(_collectionName);

        await client.InsertOneAsync(entity, new InsertOneOptions(), cancellationToken);
    }
}