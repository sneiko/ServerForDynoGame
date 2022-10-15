using GameServer.Models.Entities;

namespace GameServer.Models.Repositories;

public interface IScoreRepository: IMongoDbRepository<IScore>
{
    
}