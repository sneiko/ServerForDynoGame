using GameServer.Models.MongoDB.Repositories;
using GameServer.Models.Repositories;

namespace GameServer.Models.MongoDB;

public class UnitOfWork: IUnitOfWork
{
    private string _connectionString { get; }

    // Score
    private IScoreRepository? _score;
    public IScoreRepository Scores => _score ??= new ScoreRepository(_connectionString, "Score");

    #region Methods
    public UnitOfWork(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    #endregion
}