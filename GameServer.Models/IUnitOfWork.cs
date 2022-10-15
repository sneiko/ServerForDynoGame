using GameServer.Models.Repositories;

namespace GameServer.Models;

public interface IUnitOfWork
{
    public IScoreRepository Scores { get; }
}