using GameServer.Models.Entities;
using GameServer.Models.MongoDB.Entities;
using GameServer.Models.Repositories;

namespace GameServer.Models.MongoDB.Repositories;

public class ScoreRepository: MongoDbRepository<IScore, Score>, IScoreRepository
{
    public ScoreRepository(string connectionString, string collectionName) : base(connectionString, collectionName)
    {
    }

    protected override void MapToEntity(Score entityImpl, IScore entity)
    {
        MapToEntity(entityImpl, entity);
    }
}