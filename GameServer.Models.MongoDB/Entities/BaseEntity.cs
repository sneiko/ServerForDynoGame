using GameServer.Models.Entities;

namespace GameServer.Models.MongoDB.Entities;

public class BaseEntity: IBaseEntity
{
    public string Id { get; set; }
}