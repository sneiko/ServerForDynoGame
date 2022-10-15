using GameServer.Models.Entities;

namespace GameServer.Models.Repositories;

public interface IMongoDbRepository<T> where T : IBaseEntity
{
    Task<T> GetByIdAsync(string id, CancellationToken cancellationToken);
    Task Insert(T entity, CancellationToken cancellationToken);
}